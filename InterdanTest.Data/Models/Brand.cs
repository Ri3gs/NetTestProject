using System.Collections.Generic;

namespace InterdanTest.Data.Models
{
    public class Brand
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
