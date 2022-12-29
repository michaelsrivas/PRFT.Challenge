using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PRFT.Challenge.Api.Controllers;

[Route("api/[controller]")]
public class ClientController : ApiController
{
    [HttpGet]
    public IActionResult GetClients()
    {
        return Ok(Array.Empty<string>());
    }
}
