using Data.Models;

namespace Business
{
    public interface IMedicalReviewsBusiness
    {
        public void BookMedicalReview(int patientId, int doctorId, DateTime date);

        public bool IsDoctorFreeOnDate(int doctorId, DateTime date);

        // Returns the schedule of a doctor
        public ICollection<MedicalReview> GetUpcomingMedicalReviewsForDoctor(string email);
    }
}
