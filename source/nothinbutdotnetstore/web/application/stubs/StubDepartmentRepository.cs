using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.web.application.stubs
{
    public class StubDepartmentRepository : ICanGetDepartments
    {
        public IEnumerable<Department> get_the_main_departments_in_the_store()
        {
            return Enumerable.Range(1, 199).Select(x => new Department{name = x.ToString("Department 0")});

        }

        #region ICanGetDepartments Members


        public Department get_a_department_in_the_store(int deptID)
        {
          return new Department();
        }

        #endregion
    }
}