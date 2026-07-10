using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
namespace Management_Hospital
{
    class Room
    {
         List<Patient> Patients = new List<Patient>();
        public int RoomNumber;
        public int Capacity = 10;
        public Room(int roomNumber, int capacity)
        {
          RoomNumber = roomNumber;
            Capacity = capacity;
          }


        public void AssignPatient(Patient patient)
        {
            if (Patients.Count < Capacity)
            {
                Patients.Add(patient);
            }
            else
            {
                throw new RoomFullException("Room is full.");
            }
        }

        public Boolean RemovePatient(Patient patient)
        {


          return Patients.Remove(patient);
    
        }


      
    }
}