using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application
{
    public interface ICanGetProducts
    {
        IEnumerable<Product> get_products_in(Department parent_department);
    }
}