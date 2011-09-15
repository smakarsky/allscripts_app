using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
  [Subject(typeof(ViewAMainDepartment))]
  class ViewAMainDepartmentSpecs
  {
  
  public abstract class concern : Observes<IPerformApplicationBehaviour,
                                    ViewAMainDepartment>
    {
    }


    public class when_processing_a_request : concern
    {
      Establish c = () =>
      {
        all_main_departments = new List<Department> { new Department() };
        department_repository = depends.on<ICanGetDepartments>();
        display_engine = depends.on<IDisplayReports>();
        request = fake.an<IContainRequestInformation>();
        dept = new Department();
        department_repository.setup(x => x.get_a_department_in_the_store(8))
            .Return(dept);
        request.Parameters = "8";
      };

      Because b = () =>
          sut.process(request);

      It should_a_dept_in_the_store = () =>
          department_repository.received(x => x.get_a_department_in_the_store(8));

      It should_display_a_departments = () =>
          display_engine.received(x => x.display(dept));


      static Department dept;
      static IContainRequestInformation request;
      static ICanGetDepartments department_repository;
      static IEnumerable<Department> all_main_departments;
      static IDisplayReports display_engine;
    }
  }
}
