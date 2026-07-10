using System;
using System.Collections.Generic;
using System.Text;

namespace management_univercity
{
     abstract class Person
    {
        public string Name{ get; set; }
        public int Age {  get; set; }



        public abstract string GetDetails();
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
