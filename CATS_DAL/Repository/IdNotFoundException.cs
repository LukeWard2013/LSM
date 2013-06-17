using System;

namespace CATS_DAL.Repository
{
    public class IdNotFoundException : Exception
    {
        public IdNotFoundException(string message)
            : base(message)
        {}
    }
}