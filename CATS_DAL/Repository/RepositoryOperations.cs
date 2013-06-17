using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CATS_DAL.Model;

namespace CATS_DAL.Repository
{
    public class RepositoryOperations<TEntity> : Repository<TEntity> where TEntity:class 
    {
        public Operator GetValidInterview()
        {
            var interview = Db.Operators
                               .Where(c => c.Calls.Any(currentCall => currentCall.CurrentCall && currentCall.CallBackDate<=DateTime.Now));

            return interview.First();
        }

        public TEntity FindById(int id)
        {
            TEntity entity = Db.Set<TEntity>().Find(id);
            if (entity == null) throw new IdNotFoundException("The Id to delete was not found.");
            return entity;
        }

        public IEnumerable ValidateOperator(TEntity entity)
        {
            var result = Db.Entry(entity).GetValidationResult();
            if (!result.IsValid)
            {
                IList errors = new ArrayList();
                foreach (var error in result.ValidationErrors)
                {
                    errors.Add(error.ErrorMessage);
                }
                return errors;
            }
            {
                return "Valid";
            }
        }
    }

    public class IdNotFoundException : Exception
    {
        public IdNotFoundException(string message)
            : base(message)
        {}
    }
}
