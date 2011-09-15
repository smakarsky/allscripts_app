using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheDepartmentsInADepartment))]
    public class ViewTheDepartmentsInADepartmentSpecs
    {
        public abstract class concern : Observes<IPerformApplicationBehaviour,
                                            ViewTheDepartmentsInADepartment>
        {
        }

        public class when_observation_name : concern
        {
            It first_observation = () => 
        }
    }
}