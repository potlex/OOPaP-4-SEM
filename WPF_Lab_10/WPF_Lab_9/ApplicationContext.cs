using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab_10
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ADDRESS> Address => Set<ADDRESS>();
        public DbSet<PASSPORT> Passport => Set<PASSPORT>();
        public DbSet<PERSON> Person => Set<PERSON>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=oopdb;Integrated Security=True");
        }
    }
}
