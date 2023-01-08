using System.Net;
using System.Text.Json;

namespace SAFX.ExceptionHandling.UsingMiddleware.Middlewares;

public class ErrorHandlingMiddleware
{
	private readonly RequestDelegate next;

	public ErrorHandlingMiddleware(RequestDelegate next)
	{
		this.next = next;
	}

	public async Task Invoke(HttpContext context)
	{
		try
		{
			await next(context);
		}
		catch (Exception exception)
		{

			await HandleExceptionAsync(context, exception);
		}
	}

	private Task HandleExceptionAsync(HttpContext context, Exception exception)
	{
		var result = JsonSerializer.Serialize(new { error = "Internal server error (500) - With custom message (From middleware)" });
		context.Response.ContentType = "application/json";
		context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
		return context.Response.WriteAsync(result);
	}
}
