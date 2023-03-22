using Data.Models;

namespace Business
{
    public interface IRoomBusiness
    {
        public void CreateNewRoom();

        public void GivePatientRoom(int patientId,  int roomId);

        public void RemovePatientFromRoom(int patientId,  int roomId);

        public Patient? GetPatientInRoom(int patientId, int roomId);
    }
}
