using System;
using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class ViewTheDepartmentsInADepartment : IPerformApplicationBehaviour
    {
        ICanGetDepartments department_repository;
        IDisplayReports display_engine;

        public ViewTheDepartmentsInADepartment(ICanGetDepartments department_repository, IDisplayReports display_engine)
        {
            this.department_repository = department_repository;
            this.display_engine = display_engine;
        }

        public ViewTheDepartmentsInADepartment():this(new StubDepartmentRepository(),
            new StubDisplayEngine())
        {
        }

        public void process(IContainRequestInformation request)
        {
            display_engine.display(
                department_repository.get_the_departments_in(request.map<Department>()));
        }
    }
}