using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        /// <summary>
        /// table name will be Users
        /// </summary>
        /// <value></value>
        public DbSet<AppUser> Users { get; set; }
    }
}