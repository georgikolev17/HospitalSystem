namespace Data.Models
{
    public class Room
    {
        public Room()
        {
            this.Taken = false;
        }

        public int RoomId { get; set; }

        public bool Taken { get; set; }

        public int? PatientId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}