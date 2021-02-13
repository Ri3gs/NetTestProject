using System.Collections.Generic;

namespace InterdanTest.API.Models
{
    public class GetModelsResponse
    {
        public IEnumerable<GetModelsResponseItem> List { get; set; }
    }
}
