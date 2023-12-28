namespace Sliit.MTIT.Assignment3.Patient.Data
{
    public class PatientMockDataService
    {
        public static List<Models.Patient> Patients = new List<Models.Patient>()
        {
            new Models.Patient { Id = 1, Firstname = "Mandira", Gender = "Female", Address = "No: 678/2 Galle Road Matara", Birthdate = "04/20/1990", Contactnumber = "0412283789" },
            new Models.Patient { Id = 2, Firstname = "Binura", Gender = "Male", Address = "No: 97 Flower Road Kandy", Birthdate = "07/27/1996", Contactnumber = "0713456789" },
            new Models.Patient { Id = 3, Firstname = "Kasun", Gender = "Male", Address = "No: 2/67 Kelaniya", Birthdate = "09/08/1991", Contactnumber = "0112345678" },
            new Models.Patient { Id = 4, Firstname = "Thilini", Gender = "Female", Address = "No: 109 Colombo 10", Birthdate = "10/10/2000", Contactnumber = "0118767823" },
            new Models.Patient { Id = 5, Firstname = "Amal", Gender = "Male", Address = "No; 78 Colombo Road Galle",Birthdate = "05/12/1988", Contactnumber = "0912222850" }
        };

    }
}

