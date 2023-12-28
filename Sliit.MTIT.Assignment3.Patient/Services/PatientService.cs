using Sliit.MTIT.Assignment3.Patient.Models;
using Sliit.MTIT.Assignment3.Patient.Data;
using System.Reflection;

namespace Sliit.MTIT.Assignment3.Patient.Services
{
    public class PatientService : IPatientService
    {
        public List<Models.Patient> GetPatients()
        {
            return PatientMockDataService.Patients;
        }

        public Models.Patient? GetPatient(int id)
        {
            return PatientMockDataService.Patients.FirstOrDefault(x => x.Id == id);
        }

        public Models.Patient? AddPatient(Models.Patient patient)
        {
            PatientMockDataService.Patients.Add(patient);
            return patient;
        }

        public Models.Patient? UpdatePatient(Models.Patient patient)
        {
            Models.Patient selectedPatient = PatientMockDataService.Patients.FirstOrDefault(x => x.Id == patient.Id);
            if (selectedPatient != null)
            {
                selectedPatient.Firstname = patient.Firstname;
                selectedPatient.Gender = patient.Gender;
                selectedPatient.Birthdate = patient.Birthdate;
                selectedPatient.Address = patient.Address;
                selectedPatient.Contactnumber = patient.Contactnumber;

                return selectedPatient;
            }

            return selectedPatient;
        }

        public bool? DeletePatient(int id)
        {
            Models.Patient selectedPatient = PatientMockDataService.Patients.FirstOrDefault(x => x.Id == id);
            if (selectedPatient != null)
            {
                PatientMockDataService.Patients.Remove(selectedPatient);
                return true;
            }
            return false;
        }
    }
}
