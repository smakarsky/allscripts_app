using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application
{
    public class ViewTheMainDepartmentsInTheStore : IPerformApplicationBehaviour
    {
        ICanGetDepartments department_repository;
        IDisplayReports display_engine;

        public ViewTheMainDepartmentsInTheStore(ICanGetDepartments department_repository, IDisplayReports display_engine)
        {
            this.department_repository = department_repository;
            this.display_engine = display_engine;
        }

        public ViewTheMainDepartmentsInTheStore():this(new StubDepartmentRepository(),
            new StubDisplayEngine())
        {
        }

        public void process(IContainRequestInformation request)
        {
            display_engine.display(department_repository.get_the_main_departments_in_the_store());
        }
    }
}