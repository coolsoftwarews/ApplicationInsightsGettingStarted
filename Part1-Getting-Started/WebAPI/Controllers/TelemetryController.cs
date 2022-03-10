using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/telemetry")]
    public class TelemetryController : ControllerBase
    {
        private readonly ILogger<TelemetryController> _logger;

        public TelemetryController(ILogger<TelemetryController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/log/{message}", Name = "GetLogs")]
        public IActionResult Get(string message)
        {
   
                this._logger.LogTrace($"Test trace: {message}"); //log level: 0

                this._logger.LogDebug($"Test debug: {message}");//log level: 1

                this._logger.LogInformation($"Test information: {message}");//log level: 2

                this._logger.LogWarning($"Test warning: {message}");//log level: 3

                this._logger.LogError($"Test error: {message}");//log level: 4

                this._logger.LogCritical($"Test Critical: {message}");//log level: 5

                return Ok();
          
        }

        [HttpGet("/badrequest/{message}", Name = "GetBadRequest")]
        public IActionResult GetBadRequest(string message)
        {
            return StatusCode(500, new Exception($"Throw exception: {message }"));
         
        }

        [HttpGet("/exception/{message}", Name = "GetException")]
        public IActionResult GetException(string message)
        {
            throw new Exception($"Throw exception: {message }");
        }
    }
}