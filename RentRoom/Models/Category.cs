using System.Collections.Generic;

namespace RentRoom.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
    }
}
