using AsyncAwait.Task4.Models;
using System.Data.Entity;

namespace AsyncAwait.Task4.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
