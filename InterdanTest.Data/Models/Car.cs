using System.Collections.Generic;

namespace InterdanTest.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        public int EngineId { get; set; }

        public int Price { get; set; }

        public Model Model { get; set; }

        public Engine Engine { get; set; }

        public ICollection<CarColor> Colors { get; set; }
    }
}
