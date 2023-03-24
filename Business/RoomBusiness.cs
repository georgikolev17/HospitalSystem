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
        private ApplicationDbContext dbContext;
        public RoomBusiness()
        {
            this.dbContext = new ApplicationDbContext();
        }
        public void CreateNewRoom()
        {
            this.dbContext.Rooms.Add(new Room());
            this.dbContext.SaveChanges();
        }

        public Patient? GetPatientInRoom(int patientId, int roomId)
        {
            var patient = this.dbContext.Patients.FirstOrDefault(x => x.PatientId == patientId && x.RoomId == roomId);

            if (patient == null)
            {
                return null;
            }
            return patient;
        }

        public void GivePatientRoom(int patientId, int roomId)
        {
            var room = this.dbContext.Rooms.FirstOrDefault(x => x.RoomId == roomId);
            if (room.Taken == true)
            {
                throw new Exception("Room already taken!");
            }
            room.Patient = this.dbContext.Patients.FirstOrDefault(x => x.PatientId == patientId);
            room.PatientId = patientId;
            room.Taken = true;
            this.dbContext.SaveChanges();
        }

        public void RemovePatientFromRoom(int patientId, int roomId)
        {
            var room = this.dbContext.Rooms.FirstOrDefault(x => x.RoomId == roomId);
            if (room.Taken == false)
            {
                throw new Exception("Room is already free!");
            }
            room.Patient = null;
            room.PatientId = null;
            room.Taken = false;
            this.dbContext.SaveChanges();
        }
    }
}
