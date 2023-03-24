using Data.Models;

namespace Business
{
    public interface IDiagnosesBusiness
    {
        public ICollection<Diagnose> GetDiagnosesForPatient(int patientId);

        public void CreateDiagnose(int patientId, string illnessDescription, string prescription);
    }
}
