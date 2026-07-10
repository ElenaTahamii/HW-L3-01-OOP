using management_univercity;
using System;
using System.Collections.Generic;

namespace management_univercity
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("***********************************");
            Console.WriteLine("   UNIVERSITY MANAGEMENT SYSTEM    ");
            Console.WriteLine("***********************************");
            List<Person> people = new List<Person>();

            Student student1 = new Student("elena", 22, 147856, "computer");
            Professor professor1 = new Professor("mohammad", 58, 85475, "computer");
            people.Add(student1);
            people.Add(professor1);

            foreach (Person person in people)
            {

                Console.WriteLine(person.GetDetails());


            }
        }
    }
}