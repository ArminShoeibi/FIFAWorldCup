using FIFAWorldCup.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FIFAWorldCup.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MatchesController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<MatchDto>> GetMatches()
    {
        return Ok(new List<MatchDto>()
        {
            new(3, "England", "Iran", new DateTimeOffset(2022, 11, 20, 16, 0, 0, new TimeSpan(3, 0, 0))),
            new(17, "Iran", "Wales", new DateTimeOffset(2022, 11, 25, 13, 0, 0, new TimeSpan(3, 0, 0))),
            new(34, "Iran", "USA", new DateTimeOffset(2022, 11, 29, 22, 0, 0, new TimeSpan(3, 0, 0))),
        });
    }
}
