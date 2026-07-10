using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Hospital
{
     class Doctor:Person
    {
        public string DoctorId;
        public string Specialization;
        public Doctor(string name, int age, string nationalId, string doctorId, string specialization) : base(name, age, nationalId)
        {
            DoctorId = doctorId;
            Specialization = specialization;       
        }
        public override string GetDetails()
        {
            return $"Name:" + Name + "," + "Specialization" + Specialization + "," + "DoctorId  " + DoctorId;
        }

        public void Diagnose(Patient patient, string diseaseName)
        {
            patient.AddToMedicalHistory(diseaseName);
        }

    }
    
}
