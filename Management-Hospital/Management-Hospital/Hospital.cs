using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Hospital
{
    class Hospital
    {

        List<Patient> patients = new List<Patient>();

        List<Room> rooms = new List<Room>();

        List<Doctor> doctors = new List<Doctor>();

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void AdmitPatient(Patient patient)
        {
            bool isAssigned = false;

            foreach (Room room in rooms)
            {
                try
                {
                    room.AssignPatient(patient);
                    patients.Add(patient);
                    isAssigned = true;
                    break;

                }
                catch (RoomFullException)
                {
                }
            }
            if (!isAssigned)
            {
                Console.WriteLine("The room is not available.");
            }

        }
        // public Boolean Isremoved=false;
        public bool DischargePatient(Patient patient)
        {

            foreach (Room room in rooms)
            {

                if (room.RemovePatient(patient))

                {
                    patients.Remove(patient);

                    return true;


                }

            }

            return false;
        }

    }
}
