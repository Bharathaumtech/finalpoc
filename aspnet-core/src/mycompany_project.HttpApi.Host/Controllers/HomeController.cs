using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace mycompany_project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : AbpController
{
    //public ActionResult Index()
    //{
    //    return Redirect("~/swagger");
    //}

    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok("Hello from ABP Swagger!");
    }
}
