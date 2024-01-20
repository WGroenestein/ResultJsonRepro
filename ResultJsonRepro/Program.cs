using Microsoft.AspNetCore.Mvc;

namespace ResultJsonRepro;

public static class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddControllers();

		var app = builder.Build();

		app.MapGet("/", () => Results.Json(null));

		app.MapControllers();

		app.Run();
	}
}

public class MvcController : Controller
{
	[HttpGet("mvc")]
	public IActionResult Something()
	{
		return Json(null);
	}
}

[ApiController]
public class ApiController : Controller
{
	[HttpGet("api")]
	public IActionResult Something()
	{
		return Json(null);
	}
}
