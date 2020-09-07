using System;
using System.Collections.Generic;

namespace uppgift3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //var UserErrors = new List <UserError>();
            //UserErrors.Adnew TextInputError());   
            var userErrors = new List<UserError>
            {
                new TextInputError(),
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new UnassignedVariableError(),
                new DivideByZeroError(),
                new ArrayOutofrangeError()

            };

            foreach(var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            
        }
        

    }
}
