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
        public MedicalReviewBusiness()
        {
        }
        public void BookMedicalReview(int patientId, int doctorId, DateTime date)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            if (IsDoctorFreeOnDate(doctorId, date) == false) 
            {
                throw new Exception("Doctor not free on date!");
            }
            dbContext.Add(new MedicalReview(patientId, doctorId, date));
            dbContext.SaveChanges();
        }

        public ICollection<MedicalReview> GetUpcomingMedicalReviewsForDoctor(string email)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            DateTime today = DateTime.Now;
            var doctor = dbContext.Doctors.FirstOrDefault(x => x.Email == email);
            ICollection<MedicalReview> upcomingreviews = dbContext.MedicalReviews
                .Where(x => x.Date >= today && x.DoctorId == doctor.DoctorId)
                .ToList();
            return upcomingreviews;
        }

        public bool IsDoctorFreeOnDate(int doctorId, DateTime date)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var medicalreview = dbContext.MedicalReviews.FirstOrDefault(x => x.DoctorId == doctorId && x.Date == date);

            if (medicalreview == null) 
            {
                return true;
            }
            return false;
        }
    }
}
