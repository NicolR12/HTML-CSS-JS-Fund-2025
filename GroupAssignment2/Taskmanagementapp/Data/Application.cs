using Microsoft.EntityFrameworkCore;




namespace Taskmanagementapp.Data
{
    public class Application : DbContext
    {
        public Application(DbContextOptions<Application> options) : base(options) { }
    
    public DbSet<Application> Applications { get; set; }
    }
}
