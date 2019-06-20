using Microsoft.EntityFrameworkCore;
using Newapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Newapp.Data
{
    public class ClientDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LOTUS\SQLEXPRESS;database=ClientDb;integrated security=true;");
        }
        public DbSet<Client> Clients { get; set; }
    }
    
}
