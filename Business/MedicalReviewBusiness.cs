using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    public class MedicalReviewBusiness : IMedicalReviewsBusiness
    {
        private readonly IDiagnosesBusiness diagnosesBusiness;
        public MedicalReviewBusiness()
        {
            this.diagnosesBusiness = new DiagnosesBusiness();
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

        public void EditMedicalReview(int id, string diagnose, string prescription, int patientId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            var medicalReview = dbContext.MedicalReviews
                .Include(x => x.Diagnose)
                .FirstOrDefault(x => x.MedicalReviewId == id);
            var newDiagnose = this.diagnosesBusiness.CreateDiagnose(patientId, diagnose, prescription);
            medicalReview.DiagnoseId = newDiagnose.DiagnoseId;
            dbContext.SaveChanges();
        }

        public MedicalReview? FindMedicalReview(int doctorId, int patientId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.MedicalReviews
                .Include(x => x.Diagnose)
                .Include(x => x.Patient)
                .FirstOrDefault(x => x.DoctorId == doctorId && x.PatientId == patientId);
        }

        public ICollection<MedicalReview> GetPastMedicalReviewsForPatient(int patientId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            return dbContext.MedicalReviews
                .Include(x => x.Doctor)
                .Where(x => x.Date < DateTime.Now && patientId == x.PatientId)
                .ToList();
        }

        public ICollection<MedicalReview> GetUpcomingMedicalReviewsForDoctor(string email)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            DateTime today = DateTime.Now;
            var doctor = dbContext.Doctors.FirstOrDefault(x => x.Email == email);
            ICollection<MedicalReview> upcomingreviews = dbContext.MedicalReviews
                .Where(x => x.Date >= today && x.DoctorId == doctor.DoctorId)
                .Include(x => x.Patient)
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
