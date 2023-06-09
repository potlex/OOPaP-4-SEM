using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab_11
{
    public class ApplicationContext : DbContext
    {
        public DbSet<RECORD> Record => Set<RECORD>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=oopdb;Integrated Security=True");
        }
    }
}
