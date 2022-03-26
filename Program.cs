using System;
using System.Collections.Generic;
using TextHandlingWithAttributes.Handling;
using TextHandlingWithAttributes.Handling.Attributes;
using TextHandlingWithAttributes.Handling.Handlers;

namespace TextHandlingWithAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = @"Felipe ",
                MiddleName = @"N\A",
                LastName = @"        Alves"
            };

            HandlersFactory handlers = new HandlersFactory();
            handlers.Execute(person);

            Console.WriteLine(person);

        }
    }

    class Person 
    {
        [UpperCase]
        [Trim]
        public string FirstName { get; set; }

        [LowerCase]
        [Trim]
        [Replace("N\\A", "")]
        public string MiddleName { get; set; }
        
        [UpperCase]
        [Trim]
        public string LastName { get; set; }


        public override string ToString()
        {
            return $"FirstName: {FirstName}, MiddleName: {MiddleName}, LastName: {LastName}";
        }
    }
}
