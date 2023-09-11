using Microsoft.AspNetCore.Mvc;

namespace CustomerValidatorApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost(Name = "AddCustomer")]
        public string InsertCustomer(Customer input)
        {
            return "hello";
        }
    }
}
