using Sliit.MTIT.Assignment3.Doctor.Models;
using Sliit.MTIT.Assignment3.Doctor.Data;

namespace Sliit.MTIT.Assignment3.Doctor.Services
{
    public class DoctorService : IDoctorService
    {
        public List<Models.Doctor> GetDoctors()
        {
            return DoctorMockDataService.Doctors;
        }

        public Models.Doctor? GetDoctor(int id)
        {
            return DoctorMockDataService.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public Models.Doctor? AddDoctor(Models.Doctor doctor)
        {
            DoctorMockDataService.Doctors.Add(doctor);
            return doctor;
        }

        public Models.Doctor? UpdateDoctor(Models.Doctor doctor)
        {
            Models.Doctor selectedDoctor = DoctorMockDataService.Doctors.FirstOrDefault(x => x.Id == doctor.Id);
            if (selectedDoctor != null)
            {
                selectedDoctor.Specialist = doctor.Specialist;
                selectedDoctor.Age = doctor.Age;
                selectedDoctor.Name = doctor.Name;
                selectedDoctor.Mobilenumber = doctor.Mobilenumber;
                return selectedDoctor;
            }

            return selectedDoctor;
        }

        public bool? DeleteDoctor(int id)
        {
            Models.Doctor selectedDoctor = DoctorMockDataService.Doctors.FirstOrDefault(x => x.Id == id);
            if (selectedDoctor != null)
            {
                DoctorMockDataService.Doctors.Remove(selectedDoctor);
                return true;
            }
            return false;
        }
    }
}
