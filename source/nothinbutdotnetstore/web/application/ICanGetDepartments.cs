using System.Collections.Generic;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.web.application
{
    public interface ICanGetDepartments
    {
         IEnumerable<Department> get_the_main_departments_in_the_store();
         IEnumerable<Department> get_the_departments_in(Department parent_department);
    }
}


