using Microsoft.EntityFrameworkCore;
using Personal_Info_Management_System.Models;

namespace Personal_Info_Management_System.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalInfo> PersonalInfos { get; set; }

    }
}
