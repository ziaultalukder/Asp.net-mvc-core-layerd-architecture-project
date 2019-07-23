using RanaProject.Models.DatabaseContext;
using RanaProject.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RanaProject.Repository.Base
{
    public class Repository<T>:IRepository<T> where T: class
    {
        private readonly RanaProjectDbContext db;

        public Repository(RanaProjectDbContext db)
        {
            this.db = db;
        }

        public bool Add(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChanges() > 0;
        }
    }
}
