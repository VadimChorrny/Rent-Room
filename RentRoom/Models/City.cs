namespace RentRoom.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // кількість обєктів зданих в оренду в цьому місті
        public int ObjectAmount { get; set; } 
    }
}
