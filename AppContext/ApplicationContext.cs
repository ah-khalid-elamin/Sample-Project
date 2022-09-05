using Microsoft.EntityFrameworkCore;
using Sample_Project.Models;

namespace Sample_Project.AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                   : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
