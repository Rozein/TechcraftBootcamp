using Microsoft.AspNetCore.Mvc;

namespace RunTime_UserApplication_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost(Name = "AddCustomer")]
        public string InsertCustomer(Customer ust)
        {
            return "success";
        }
    }
}
