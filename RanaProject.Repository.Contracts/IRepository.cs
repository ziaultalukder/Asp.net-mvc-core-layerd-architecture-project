using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.Repository.Contracts
{
    public interface IRepository<T> where T: class
    {
        bool Add(T entity);
    }
}
