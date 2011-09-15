namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubMissingCommand :IProcessARequest
    {
        public void process(IContainRequestInformation request)
        {

        }

        public bool can_handle(IContainRequestInformation request)
        {
            return false;
        }
    }
}