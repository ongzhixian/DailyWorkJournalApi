using Microsoft.AspNetCore.Mvc;

namespace DailyWorkJournalWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CrashController : ControllerBase
{


    private readonly ILogger<CrashController> _logger;

    public CrashController(ILogger<CrashController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCrash")]
    public void Get()
    {
        throw new NotImplementedException();
    }
}
