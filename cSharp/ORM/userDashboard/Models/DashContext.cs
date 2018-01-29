using Microsoft.EntityFrameworkCore;
 
namespace userDashboard.Models
{
    public class DashContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DashContext(DbContextOptions<DashContext> options) : base(options) { }
        //<User> stands for Module , Users stands for table name of db table
        public DbSet<User> Users {get; set;}
        public DbSet<Message> Messages {get; set;}
        public DbSet<Comment> Comments {get; set;}
    }
}