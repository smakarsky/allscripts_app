using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewTheMainDepartmentsInTheStore : IPerformApplicationBehaviour
    {
        ICanGetDepartments department_repository;

        public ViewTheMainDepartmentsInTheStore(ICanGetDepartments department_repository)
        {
            this.department_repository = department_repository;
        }

        public void process(IContainRequestInformation request)
        {
            department_repository.get_the_main_departments_in_the_store();
        }
    }
}