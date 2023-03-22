using Data.Models;

namespace Business
{
    public interface IDiagnosesBusiness
    {
        public ICollection<Diagnose> GetDiagnosesForPatient(string email);

        public void CreateDiagnose(int patientId, string illnessDescription);
    }
}
