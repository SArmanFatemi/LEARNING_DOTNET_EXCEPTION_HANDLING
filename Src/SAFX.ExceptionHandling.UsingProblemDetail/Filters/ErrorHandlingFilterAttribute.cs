namespace SAFX.ExceptionHandling.UsingProblemDetail.Filters;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
	public override void OnException(ExceptionContext context)
	{
		// The exception object is in context.Exception;
		Exception exception = context.Exception;
		ProblemDetails problemDetails = new()
		{
			Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
			Title = "Internal server error (500) - With custom message (From filter using problem detail)",
			Status = (int)HttpStatusCode.InternalServerError
		};

		context.Result = new ObjectResult(problemDetails);
		context.ExceptionHandled = true;
	}
}
