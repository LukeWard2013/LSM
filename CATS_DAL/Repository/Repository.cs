using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CATS_DAL.Model;

namespace CATS_DAL.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        public CatsDatabaseContext Db;

        public Repository()
        {
            //Use SQL Compact for testing
            Db = new CatsDatabaseContext();
        }

        public TEntity FindById(int id)
        {
            TEntity entity = Db.Set<TEntity>().Find(id);
            if (entity == null) throw new IdNotFoundException("The Id to delete was not found.");
            return entity;
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
