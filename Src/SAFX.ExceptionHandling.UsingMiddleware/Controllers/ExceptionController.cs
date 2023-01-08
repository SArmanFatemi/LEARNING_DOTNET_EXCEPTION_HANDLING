using Microsoft.AspNetCore.Mvc;

namespace SAFX.ExceptionHandling.UsingMiddleware.Controllers
{
	[ApiController]
	public class ExceptionController : ControllerBase
	{
		[HttpGet("throw-new-exception")]
		public IActionResult Get()
		{
			throw new Exception("Some excpetion raised here");
		}
	}
}