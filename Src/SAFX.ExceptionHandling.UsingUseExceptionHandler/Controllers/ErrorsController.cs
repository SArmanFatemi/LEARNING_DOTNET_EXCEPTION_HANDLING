namespace SAFX.ExceptionHandling.UsingUseExceptionHandler.Controllers;

using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class ErrorsController : ControllerBase
{
	[HttpGet]
	[Route("/error")]
	public IActionResult Error()
	{
		Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

		return Problem(title: exception?.Message);
	}
}