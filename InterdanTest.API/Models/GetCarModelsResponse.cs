using System.Collections.Generic;

namespace InterdanTest.API.Models
{
    public class GetCarModelsResponse
    {
        public IEnumerable<CarModel> CarModels { get; set; }
    }
}
