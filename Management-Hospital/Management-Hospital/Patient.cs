using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Management_Hospital
{
    class Patient : Person
    {
        public string PatientId;
        List<string> MedicalHistory = new List<string>();


        public override string GetDetails()
        {
            return $"PatientId :  "+PatientId  + "Name : "+Name + "Age: " + Age+  "NationaId : " + NationalId   ;
        }

        public void AddToMedicalHistory(string diseaseName)

        {
            MedicalHistory.Add(diseaseName);

        }
        public Patient(string name,int age,string nationalId,string patientId):base(name,age,nationalId) 
        {
                PatientId= patientId;

        }


    }



}   

