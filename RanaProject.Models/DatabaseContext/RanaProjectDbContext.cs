using Microsoft.EntityFrameworkCore;
using RanaProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.Models.DatabaseContext
{
    public class RanaProjectDbContext:DbContext
    {
        public RanaProjectDbContext(DbContextOptions<RanaProjectDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
