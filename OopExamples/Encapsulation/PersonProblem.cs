using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.Encapsulation
{
    public class PersonProblem
    {
        public string firstName;
        public string lastName;
        public string middleName;

        public DateTime birthday;

        public string snils;

        //public void PrintPersonInfo()
        //{
        //    Console.WriteLine($"{lastName} {firstName} {middleName}");
        //}

        //v.2
        public void PrintPersonInfo()
        {
            Console.WriteLine($"{lastName} {firstName} {middleName} {birthday:dd.MM.yyyy}, СНИЛС:{snils}");
        }



    }

    public static class PersonProblemExample
    {
        public static void Run()
        {
            //ожидаемое использование
            PersonProblem person = new PersonProblem();
            person.firstName = "Иван";
            person.lastName = "Иванов";
            person.middleName = "Иванович";
            person.birthday = DateTime.Parse("01.01.2000");
            person.snils = "50911261248";
            person.PrintPersonInfo();

            //использование внешним клиентом
            PersonProblem person2 = new PersonProblem();
            person2.firstName = "Иван Иванович Иванов";
            person2.snils = "50 911 26 12-48";
            person2.PrintPersonInfo();


        }
    }
}
