using RanaProject.Repository.Base;
using RanaProject.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.BLL.Base
{
    public class Manager<T>:IManager<T> where T:class
    {
        private readonly IRepository<T> repository;

        public Manager(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public bool Add(T entity)
        {
            return repository.Add(entity);
        }
    }
}
