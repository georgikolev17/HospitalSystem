using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MedicalReviewBusiness : IMedicalReviewsBusiness
    {
        private ApplicationDbContext dbContext;
        public MedicalReviewBusiness()
        {
            this.dbContext = new ApplicationDbContext();
        }
        public void BookMedicalReview(int patientId, int doctorId, DateTime date)
        {
            if (IsDoctorFreeOnDate(doctorId, date) == false) 
            {
                throw new Exception("Doctor not free on date!");
            }
            this.dbContext.Add(new MedicalReview(patientId, doctorId, date));
            this.dbContext.SaveChanges();
        }

        public ICollection<MedicalReview> GetUpcomingMedicalReviewsForDoctor(string email)
        {
            DateTime today = DateTime.Now;
            var doctor = this.dbContext.Doctors.FirstOrDefault(x => x.Email == email);
            ICollection<MedicalReview> upcomingreviews = this.dbContext.MedicalReviews
                .Where(x => x.Date >= today && x.DoctorId == doctor.DoctorId)
                .ToList();
            return upcomingreviews;
        }

        public bool IsDoctorFreeOnDate(int doctorId, DateTime date)
        {
            var medicalreview = this.dbContext.MedicalReviews.FirstOrDefault(x => x.DoctorId == doctorId && x.Date == date);

            if (medicalreview == null) 
            {
                return true;
            }
            return false;
        }
    }
}
