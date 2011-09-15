using System.Web;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : ICreateRequests
    {
        public IContainRequestInformation create_request_from(HttpContext an_incoming_httpcontext)
        {
            return new StubRequest();
        }

        class StubRequest : IContainRequestInformation
        {
            public InputModel map<InputModel>()
            {
                object department = new Department();
                return (InputModel) department;
            }

            #region IContainRequestInformation Members

          public string Parameters
          {
            get
              ;
            set;
          }

          #endregion
        }
    }
}