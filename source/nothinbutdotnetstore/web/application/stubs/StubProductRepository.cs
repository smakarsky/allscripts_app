using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.web.application.stubs
{
    public class StubProductRepository : ICanGetProducts
    {
        public IEnumerable<Product> get_products_in(Department parent_department)
        {
            return Enumerable.Range(1, 199).Select(x => new Product { name = x.ToString("Product 0") });
        }
    }
}