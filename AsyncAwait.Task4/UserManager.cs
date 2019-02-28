using AsyncAwait.Task4.Models;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncAwait.Task4
{
    public class UserManager
    {
        private const string ConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\Hleb_Liahchylau\source\repos\MentoringL2\AsyncAwait.Task4\Database.mdf;
            Integrated Security=True";

        private DataContext _dataContext = new DataContext(ConnectionString);

        public User GetUser(int userId)
        {
            return _dataContext
                .GetTable<User>()
                .FirstOrDefault(user => user.Id.Equals(userId));
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await Task.Run(() => GetUser(userId));
        }

        public IList<User> GetAllUsers()
        {
            return _dataContext.GetTable<User>().ToList();
        }

        public async Task<IList<User>> GetAllUsersAsync()
        {
            return await Task.Run(() => GetAllUsers());
        }

        public void AddUser(User user)
        {
            _dataContext.GetTable<User>().InsertOnSubmit(user);
            _dataContext.SubmitChanges();
        }

        public async Task AddUserAsync(User user)
        {
            await Task.Run(() => AddUser(user));
        }

        public void UpdateUser(User user)
        {
            var updatedUser = GetUser(user.Id);

            updatedUser.Name = user.Name;
            updatedUser.SecondName = user.SecondName;
            updatedUser.Age = user.Age;

            _dataContext.SubmitChanges();
        }

        public async Task UpdateUserAsync(User user)
        {
            await Task.Run(() => UpdateUser(user));
        }

        public void DeleteUser(int userId)
        {
            var updatedUser = GetUser(userId);

            _dataContext.GetTable<User>().DeleteOnSubmit(updatedUser);
            _dataContext.SubmitChanges();
        }

        public async Task DeleteUserAsync(int userId)
        {
            await Task.Run(() => DeleteUser(userId));
        }
    }
}
