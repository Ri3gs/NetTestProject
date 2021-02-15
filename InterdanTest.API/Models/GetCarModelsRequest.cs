using InterdanTest.Common.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InterdanTest.API.Models
{
    public class GetCarModelsRequest
    {
        [FromQuery(Name = "Brand")]
        public HashSet<string> Brands { get; set; }

        [FromQuery(Name = "ModelType")]
        public HashSet<ModelType> ModelTypes { get; set; }

        [FromQuery(Name = "Fuel")]
        public HashSet<FuelType> Fuels { get; set; }

        [FromQuery(Name = "Gear")]
        public HashSet<GearType> Gears { get; set; }

        public int? MinPrice { get; set; }

        public int? MaxPrice { get; set; }
    }
}
