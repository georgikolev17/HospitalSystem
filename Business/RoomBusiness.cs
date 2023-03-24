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
        private readonly IUsersBusiness usersBusiness;
        public RoomBusiness()
        {
            usersBusiness = new UsersBusiness();
        }
        public void CreateNewRoom()
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            dbContext.Rooms.Add(new Room());
            dbContext.SaveChanges();
        }

        public ICollection<Room> GetAllFreeRooms(int patientId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            var rooms = dbContext.Rooms.Where(x => x.Taken == false || x.PatientId == patientId).ToList();
            return rooms;
        }

        public Patient? GetPatientInRoom(int patientId, int roomId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var patient = dbContext.Patients.FirstOrDefault(x => x.PatientId == patientId && x.RoomId == roomId);

            if (patient == null)
            {
                return null;
            }
            dbContext.SaveChanges();
            return patient;
        }

        public int? GetPatientRoom(int patientId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.Rooms.FirstOrDefault(x => x.PatientId == patientId)?.RoomId;
        }

        public void GivePatientRoom(int patientId, int roomId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var room = dbContext.Rooms.FirstOrDefault(x => x.RoomId == roomId);
            if (room.Taken == true)
            {
                throw new Exception("Room already taken!");
            }
            var oldRoom = GetPatientRoom(patientId);
            if (oldRoom != null) 
            {
                var r = dbContext.Rooms.FirstOrDefault(x => x.RoomId == oldRoom);
                r.PatientId = null;
                r.Patient = null;
                room.Taken = false;
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
