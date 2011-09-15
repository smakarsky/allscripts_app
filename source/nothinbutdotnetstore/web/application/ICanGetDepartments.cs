using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application
{
    public interface ICanGetDepartments
    {
         IEnumerable<Department> get_all_department();
    }
}