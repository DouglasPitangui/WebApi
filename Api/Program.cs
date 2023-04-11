using Application;
using Infrastructure;
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);
{
	builder.Services
		.AddApplication()
		.AddInfrastructure();

	builder.Services.AddControllers();
}

var app = builder.Build();
{
	app.UseHttpsRedirection();
	app.MapControllers();
	app.Run();
}
