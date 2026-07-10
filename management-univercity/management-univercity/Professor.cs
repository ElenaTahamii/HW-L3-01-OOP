using System;
using System.Collections.Generic;
using System.Text;

namespace management_univercity
{
    class Professor : Person
    {
        public int ProfessorID { get; set; }
        public string Subject { get; set; }

        public Professor(string name, int age, int professorID, string subject) : base(name, age)
        {
            ProfessorID = professorID;
            Subject = subject;
        }


        public override string GetDetails()
        {

            return $" Information of Professor : Name is : {Name} ,  Age is {Age}  , ProfessorID : {ProfessorID} , Subject : {Subject}";
        }
    }
}
