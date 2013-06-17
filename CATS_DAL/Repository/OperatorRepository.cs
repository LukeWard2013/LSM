using System;
using System.Collections.Generic;
using System.Linq;
using CATS_DAL.Model;

namespace CATS_DAL.Repository
{
    public class OperatorRepository : Repository<Operator>
    {
        public Operator GetValidInterview()
        {
            var interview = Db.Operators
                               .Where(c => c.Calls.Any(currentCall => currentCall.CurrentCall && currentCall.CallBackDate <= DateTime.Now));

            return interview.First();
        }



        public IEnumerable<string> ValidateOperator(Operator @operator)
        {
            var result = Db.Entry(@operator).GetValidationResult();
            if (!result.IsValid)
            {
                return result.ValidationErrors.Select(error => error.ErrorMessage);
            }
            return new []{"Valid"};
            
        }
    }
}
