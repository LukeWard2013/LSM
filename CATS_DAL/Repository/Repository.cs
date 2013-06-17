
using System;
using System.Collections;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CATS_DAL.Model;

namespace CATS_DAL.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        public CatsDatabaseContext Db;

        public Repository()
        {
            //Use SQL Compact for testing
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0",
                                                                           @"..\Repository", "");
            Db = new CatsDatabaseContext();
        }

        public int Save(TEntity entity)
        {
            return Db.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            Db.Set<TEntity>().Add(entity);
            Db.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            Db.SaveChanges();
        }

    }
}
