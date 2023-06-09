﻿using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DiagnosesBusiness : IDiagnosesBusiness
    {
        private IUsersBusiness usersBusiness;
        public DiagnosesBusiness()
        {
            usersBusiness = new UsersBusiness();
        }
        public Diagnose CreateDiagnose(int patientId, string illnessDescription, string prescription)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            if (usersBusiness.GetUserById(patientId) == null) 
            {
                throw new Exception("The patient you want to create diagnose for does not exists.");
            }
            var diagnose = new Diagnose(patientId, illnessDescription, prescription);
            dbContext.Diagnoses.Add(diagnose);
            dbContext.SaveChanges();
            return diagnose;
        }

        public ICollection<Diagnose> GetDiagnosesForPatient(int patientId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            if (usersBusiness.GetUserById(patientId) == null)
            {
                throw new Exception("The patient you want to get diagnoses for does not exists.");
            }
            return dbContext.Diagnoses
                .Where(x => x.PatientId == patientId)
                .ToList();
        }
    }
}
