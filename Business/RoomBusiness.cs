using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RoomBusiness : IRoomBusiness
    {
        public RoomBusiness()
        {
        }
        public void CreateNewRoom()
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            dbContext.Rooms.Add(new Room());
            dbContext.SaveChanges();
        }

        public Patient? GetPatientInRoom(int patientId, int roomId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var patient = dbContext.Patients.FirstOrDefault(x => x.PatientId == patientId && x.RoomId == roomId);

            if (patient == null)
            {
                return null;
            }
            return patient;
        }

        public void GivePatientRoom(int patientId, int roomId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var room = dbContext.Rooms.FirstOrDefault(x => x.RoomId == roomId);
            if (room.Taken == true)
            {
                throw new Exception("Room already taken!");
            }
            room.Patient = dbContext.Patients.FirstOrDefault(x => x.PatientId == patientId);
            room.PatientId = patientId;
            room.Taken = true;
            dbContext.SaveChanges();
        }

        public void RemovePatientFromRoom(int patientId, int roomId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            var room = dbContext.Rooms.FirstOrDefault(x => x.RoomId == roomId);
            if (room.Taken == false)
            {
                throw new Exception("Room is already free!");
            }
            room.Patient = null;
            room.PatientId = null;
            room.Taken = false;
            dbContext.SaveChanges();
        }
    }
}
