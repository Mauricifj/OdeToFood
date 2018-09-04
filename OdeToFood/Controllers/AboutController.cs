using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    // company/about/phone
    // [Route("company/[controller]/[action]")]

    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "0800-123-1234";
        }

        public string Address()
        {
            return "Brazil";
        }
    }
}
