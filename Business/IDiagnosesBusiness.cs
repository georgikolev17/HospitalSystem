using Data.Models;

namespace Business
{
    public interface IDiagnosesBusiness
    {
        public ICollection<Diagnose> GetDiagnosesForPatient(int patientId);

        public Diagnose CreateDiagnose(int patientId, string illnessDescription, string prescription);
    }
}
