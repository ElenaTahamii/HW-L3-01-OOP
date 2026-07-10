

using Management_Hospital;

class Program
{ 

    public static void Main()
    {
        Patient patient1 = new Patient("sara", 25, "052055178", "7859");
        Patient patient2 = new Patient("elham",12 , "05208878","7856");
        Patient patient3 = new Patient("ali",34,"124985","55884");

        Doctor dictor1= new Doctor("alireza",40,"0529785","7854855","norologe");
        Doctor dictor2 = new Doctor("elhame",37,"78585","978581","noro");
        Doctor dictor3 = new Doctor("zahra",56,"58525","28455","abs");
        Doctor dictor4 = new Doctor("mohamad",52,"484512","5421","asws");

        Room room1 = new Room(101,10);
        Room room2 = new Room(105,2);
        Room room3 = new Room(109,4);
        Room room4 = new Room(110,3);
        Hospital hospital1 = new Hospital();
        hospital1.AddDoctor(dictor1);
        hospital1.AddDoctor(dictor2);
        hospital1.AddDoctor(dictor3);
        hospital1.AddDoctor(dictor4);
        hospital1.AddRoom(room1);
        hospital1.AddRoom(room2);
        hospital1.AddRoom(room3);
        hospital1.AddRoom(room4);
        hospital1.AdmitPatient(patient1);
        hospital1.AdmitPatient(patient2);
        hospital1.AdmitPatient(patient3);
        dictor2.Diagnose(patient1, "cold");
        dictor1.Diagnose(patient2, "cold");
        hospital1.DischargePatient(patient1);
    }













}