using System;
using CATS_DAL.Model;
using CATS_DAL.Repository;
using NUnit.Framework;

namespace CRUD_Tests
{
    class MyClass
    {
        private Operator _operator = new Operator();
        [Test]
        public void Add_an_operator()
        {
            //Add a company
            var repository = new Repository<Operator>();

            repository.Add(_operator);
        }

        [Test]
        public void Should_fail_validation_name_too_short()
        {
            var repo = new OperatorRepository();

            var errors = repo.ValidateOperator(_operator);

            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
        }         
    }
}