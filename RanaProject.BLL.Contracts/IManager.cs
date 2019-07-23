using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.BLL.Contracts
{
    public interface IManager<T> where T : class
    {
        bool Add(T entity);
    }
}
