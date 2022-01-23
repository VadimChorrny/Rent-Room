using System;

namespace RentRoom.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int RoomQuantity { get; set; }
        public string Description { get; set; }
        public int SleepingPlaces { get; set; }
        public DateTime PostedDate { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
