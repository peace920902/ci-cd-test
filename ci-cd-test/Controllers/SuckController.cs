using System.Threading.Tasks;
using Lib;
using Microsoft.AspNetCore.Mvc;

namespace ci_cd_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuckController : Controller
    {
        private readonly ISuckService _suckService;

        public SuckController(ISuckService suckService)
        {
            _suckService = suckService;
        }
        [HttpGet]
        public string Suck()
        {
            return _suckService.SuckMyDick();
        }
    }
}