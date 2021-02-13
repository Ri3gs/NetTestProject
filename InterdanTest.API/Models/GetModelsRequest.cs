using InterdanTest.Common.Enums;
using System.Collections.Generic;

namespace InterdanTest.API.Models
{
    public class GetModelsRequest
    {
        public HashSet<string> Brand { get; set; }

        public HashSet<ModelType> ModelType { get; set; }

        public HashSet<FuelType> Fuel { get; set; }

        public HashSet<GearType> Gear { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }
    }
}
