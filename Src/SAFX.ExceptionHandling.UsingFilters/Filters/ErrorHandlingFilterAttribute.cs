namespace SAFX.ExceptionHandling.UsingFilters.Filters;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
	public override void OnException(ExceptionContext context)
	{
		// The exception object is in context.Exception;

		context.Result = new ObjectResult(new { error = "Internal server error (500) - With custom message (From filter)" })
		{
			StatusCode = (int)HttpStatusCode.InternalServerError
		};

		context.ExceptionHandled = true;
	}
}
