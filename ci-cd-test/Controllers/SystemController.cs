using System;
using Lazcat.Infrastructure.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace ci_cd_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemController : Controller
    {
        [HttpGet]
        public DateTime GetBuildTime()
        {
            return AssemblyVersionHelper.GetBuildTime();
        }
    }
}