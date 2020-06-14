using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.Encapsulation
{
    public class PersonSolution
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        private string snils;

        public PersonSolution(string firstName, string lastName, string middleName, DateTime birthday)
        {

            if (firstName.Contains(" ") || lastName.Contains(" ") || middleName.Contains(" "))
            {
                throw new ArgumentException("недопустимое имя");
            }

            if(birthday > DateTime.Now)
            {
                throw new ArgumentException("недопустимая дата рождения");
            }

            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.birthday = birthday;
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }

        public void PrintPersonInfo()
        {
            Console.WriteLine($"{lastName} {firstName} {middleName} {birthday:dd.MM.yyyy}, СНИЛС:{snils}");
        }

        
        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string MiddleName
        {
            get { return middleName; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
        }


        public string Snils { 
            get { return snils; }
            set {
                if (value.Length > 11)
                {
                    throw new ArgumentException("ошибка в СНИЛС");
                }
                snils = value;
            } }

    }

    public static class PersonSolutionExample
    {
        public static void Run()
        {
            //ожидаемое использование и реальное использование
            PersonSolution person = new PersonSolution("Иван", "Иванов", "Иванович", DateTime.Parse("01.01.2000"));
         
            person.Snils = "50911261248";
            string firstName = person.FirstName;

            person.PrintPersonInfo();

        }
    }
}
