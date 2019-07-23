using RanaProject.Models.DatabaseContext;
using RanaProject.Models.Models;
using RanaProject.Repository.Base;
using RanaProject.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RanaProjectDbContext db) : base(db)
        {
        }
    }
}
