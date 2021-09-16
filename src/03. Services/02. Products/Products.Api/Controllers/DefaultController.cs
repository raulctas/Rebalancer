using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Products.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Running ..";
        }
    }
}
