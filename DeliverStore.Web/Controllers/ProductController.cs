using Microsoft.AspNetCore.Mvc;

namespace DeliverStore.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }
}
