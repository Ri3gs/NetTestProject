using InterdanTest.Common.Enums;
using System.Collections.Generic;

namespace InterdanTest.Data.Models
{
    public class Engine
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public FuelType Fuel { get; set; }

        public GearType Gear { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
