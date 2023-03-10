using SAFX.ExceptionHandling.UsingProblemDetail.Filters;

var builder = WebApplication.CreateBuilder(args);
{
	builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
	builder.Services.AddEndpointsApiExplorer();
	builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
	if (app.Environment.IsDevelopment())
	{
		app.UseSwagger();
		app.UseSwaggerUI();
	}
	app.MapControllers();
}

app.Run();
