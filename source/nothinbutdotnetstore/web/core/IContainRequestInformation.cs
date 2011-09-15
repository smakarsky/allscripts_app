using System.Collections.Generic;
namespace nothinbutdotnetstore.web.core
{
    public interface IContainRequestInformation
    {
        IEnumerable<object> results { get; set; }
    }
}