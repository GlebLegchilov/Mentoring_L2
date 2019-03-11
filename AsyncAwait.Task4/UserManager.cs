using AsyncAwait.Task4.Contexts;
using AsyncAwait.Task4.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncAwait.Task4
{
    public class UserManager
    {
        private UserContext _userContext = new UserContext();

        public User GetUser(int userId)
        {
            return _userContext
                .Users
                .FirstOrDefault(storedUser => storedUser.Id.Equals(userId));
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await _userContext
                    .Users
                    .FirstOrDefaultAsync(user => user.Id.Equals(userId));
        }

        public async Task<IList<User>> GetAllUsersAsync()
        {
            return await _userContext
                .Users
                .ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            _userContext.Users.Add(user);
            await _userContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            var updatedUser = GetUser(user.Id);
            
            updatedUser.Name = user.Name;
            updatedUser.SecondName = user.SecondName;
            updatedUser.Age = user.Age;

            await _userContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int userId)
        {
            var updatedUser = GetUser(userId);

            _userContext.Users.Remove(updatedUser);
            await _userContext.SaveChangesAsync();
        }
    }
}

