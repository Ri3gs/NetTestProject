using InterdanTest.Common.Enums;
using System.Collections.Generic;

namespace InterdanTest.Data.Models
{
    public class Model
    {
        public int Id { get; set; }

        public int BarndId { get; set; }

        public string Name { get; set; }

        public ModelType Type { get; set; }

        public Brand Brand { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
