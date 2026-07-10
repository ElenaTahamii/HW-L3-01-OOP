using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Hospital
{
    abstract class Person
    {
        public string Name;
        public int Age;
        public string NationalId;
        public abstract string GetDetails();
       
        public Person(string name,int age,string nationalId) {
        
      Name = name;
            Age = age;
            NationalId = nationalId;
        
        
        }

    }
}
