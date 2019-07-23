using RanaProject.BLL.Base;
using RanaProject.BLL.Contracts;
using RanaProject.Models.Models;
using RanaProject.Repository;
using RanaProject.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.BLL
{
    public class EmployeeManager : Manager<Employee>, IEmployeeManager
    {
        private readonly IEmployeeRepository repository;

        public EmployeeManager(IEmployeeRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
