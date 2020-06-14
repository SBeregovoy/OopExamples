using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples
{
    class Person
    {
        public Person(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;

        }

        public string FirstName { get { return firstName; } 
            
            set {
                if (firstName.Contains(" "))
                    throw new ArgumentException();

                firstName = value; 
            } }


        public string LastName { get { return lastName; } set { lastName = value; } }

        public string FullName { get { return $"{firstName} {lastName}"; } }



        private string firstName;
        private string lastName;


    }
}
