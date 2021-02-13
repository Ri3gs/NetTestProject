using InterdanTest.Common.Enums;

namespace InterdanTest.API.Models
{
    public class CarModel
    {
        public int CarId { get; set; }

        public int ColorId { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public ModelType ModelType { get; set; }

        public string Engine { get; set; }

        public FuelType Fuel { get; set; }

        public GearType Gear { get; set; }

        public string Color { get; set; }

        public int MinPrice { get; set; }
    }
}
