﻿namespace Data.Models
{
    public class Room
    {
        public Room()
        {
        }

        public int Id { get; set; }

        public bool Taken { get; set; }

        public int? PatientId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}