using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;
using System.Linq;

namespace nothinbutdotnetstore.specs
{
    [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
    public class ViewTheMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<IPerformApplicationBehaviour,
                                            ViewTheMainDepartmentsInTheStore>
        {
        }

        public class when_processing_a_request : concern
        {
            Establish c = () =>
            {
                departments = Enumerable.Range(1, 50).Select(x => fake.an<Department>()).ToList();
                department_finder = depends.on<ICanGetDepartments>();
                request = fake.an<IContainRequestInformation>();
                department_finder.setup(x => x.get_all_department()).Return(departments);

            };

            Because b = () =>
                sut.process(request);


            It should_get_a_list_of_the_main_departments_in_the_store = () =>
            {
                department_finder.received(x => x.get_all_department());
                request.results.Count().ShouldEqual(departments.Count);
            };
                

            static IContainRequestInformation request;
            static ICanGetDepartments department_finder;
            static System.Collections.Generic.List<Department> departments;
        }
    }
}