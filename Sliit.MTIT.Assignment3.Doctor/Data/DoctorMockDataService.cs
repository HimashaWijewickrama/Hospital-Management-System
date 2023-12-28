namespace Sliit.MTIT.Assignment3.Doctor.Data
{
    public class DoctorMockDataService
    {
        public static List<Models.Doctor> Doctors = new List<Models.Doctor>()
        {
            new Models.Doctor { Id = 1, Name = "Himashaa", Specialist = "Surgery", Age = 29, Mobilenumber = "0787898767" },
            new Models.Doctor { Id = 2, Name = "Lakindu", Specialist = "Neurology", Age = 30, Mobilenumber = "0776787678" },
            new Models.Doctor { Id = 3, Name = "Tharindu", Specialist = "Allergy and Immunology", Age = 50, Mobilenumber = "0767876789" },
            new Models.Doctor { Id = 4, Name = "Saranga", Specialist = "Nuclear Medicine", Age = 32, Mobilenumber = "0711234567" },
            new Models.Doctor { Id = 5, Name = "Prabhashi", Specialist = "Radiation Oncology", Age = 40, Mobilenumber = "0723434567" }
        };

    }
}
