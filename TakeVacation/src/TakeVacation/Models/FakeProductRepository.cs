using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeVacation.Models
{
    public class FakeProductRepository /* : IProductRepository */
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product {Name = "Egypt", Price=1500 },
            new Product {Name = "USA and Canada", Price=500 },
            new Product {Name = "India", Price=1500 }
        };
    }
}
