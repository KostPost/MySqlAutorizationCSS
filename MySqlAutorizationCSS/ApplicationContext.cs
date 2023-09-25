using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MySqlAutorizationCSS
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Account> acc_authorization { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=kostpost;database=authorization;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
    }
}
