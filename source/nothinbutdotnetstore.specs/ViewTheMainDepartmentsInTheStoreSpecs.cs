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
                department_repository = depends.on<ICanGetDepartments>();
                request = fake.an<IContainRequestInformation>();
            };

            Because b = () =>
                sut.process(request);


            It should_get_a_list_of_the_main_departments_in_the_store = () =>
                department_repository.received(x => x.get_the_main_departments_in_the_store());


            static IContainRequestInformation request;
            static ICanGetDepartments department_repository;
        }
    }
}