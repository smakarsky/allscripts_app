using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application
{
  public class ViewAMainDepartment : IPerformApplicationBehaviour
  {
    ICanGetDepartments department_repository;
    IDisplayReports display_engine;

    public ViewAMainDepartment(ICanGetDepartments department_repository, IDisplayReports display_engine)
        {
            this.department_repository = department_repository;
            this.display_engine = display_engine;
        }

    public ViewAMainDepartment()
      : this(new StubDepartmentRepository(),
            new StubDisplayEngine())
        {
        }

    #region IPerformApplicationBehaviour Members

    public void process(IContainRequestInformation request)
    {
      display_engine.display(department_repository.get_a_department_in_the_store(Convert.ToInt32(request.Parameters)));
    }

    #endregion
  }
}
