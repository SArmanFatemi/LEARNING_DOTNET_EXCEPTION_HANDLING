namespace SAFX.ExceptionHandling.UsingUseExceptionHandler.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
public class ExceptionController : ControllerBase
{
	[HttpGet("throw-new-exception")]
	public IActionResult Get()
	{
		throw new Exception("Some excpetion raised here");
	}
}