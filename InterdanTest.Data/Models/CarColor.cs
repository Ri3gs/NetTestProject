namespace InterdanTest.Data.Models
{
    public class CarColor
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int ColorId { get; set; }

        public int Price { get; set; }

        public Car Car { get; set; }

        public Color Color { get; set; }
    }
}
