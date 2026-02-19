using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pr29.Classes.Common;
using Pr29.Models;

namespace Pr29.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public UserContext() =>
            Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
        }
    }
}
