using System;
using System.Collections.Generic;
using System.Text;

namespace management_univercity
{
   class Student:Person
    {
        public int StudentID {  get; set; }
        public string Major {  get; set; }

        public Student(string name,int age,int studentID,string major):base(name,age)
        { 
            StudentID = studentID;
            Major = major;


        
        }

        

        public override string GetDetails()
        {

            return $" Information of Student : Name is : {Name} ,  Age is {Age}  , StudentID : {StudentID} , Major : {Major}";

           
        }
    }
}
