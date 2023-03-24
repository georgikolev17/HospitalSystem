using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=HospitalDb;user=root;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(patient =>
            {
                patient.ToTable("Patients");
                patient.HasKey(p => p.PatientId);

                patient.HasOne(p => p.Room).WithOne(r => r.Patient).HasForeignKey<Room>(r => r.PatientId);
            });

            modelBuilder.Entity<Room>(room =>
            {
                room.ToTable("Rooms");
                room.HasKey(r => r.RoomId);

                room.Property(r => r.Taken).HasDefaultValue(false);
            });

            modelBuilder.Entity<Doctor>(doctor =>
            {
                doctor.ToTable("Doctors");
                doctor.HasKey(d => d.DoctorId);
            });

            modelBuilder.Entity<Diagnose>(diagnose =>
            {
                diagnose.ToTable("Diagnoses");
                diagnose.HasKey(d => d.DiagnoseId);
            });

            modelBuilder.Entity<MedicalReview>(medicalreview =>
            {
                medicalreview.ToTable("MedicalReviews");
                medicalreview.HasKey(mr => mr.MedicalReviewId);
            });
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<MedicalReview> MedicalReviews { get; set; }
    }
}
