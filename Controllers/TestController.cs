using Microsoft.AspNetCore.Mvc;

namespace CitiesManagerWebAPI.Controllers
{
    public class TestController : CustomControllerBase
    {
        [HttpGet]
        public string Method()
        {
            return "Hello World";
        }
    }
}
