// Program.cs
using System.IO;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext context) => {
    context.Response.ContentType = "text/html";

    // Read content from the HTML file
    string htmlContent = await File.ReadAllTextAsync("wwwroot/index.html");

    await context.Response.WriteAsync(htmlContent);
});

// Add this line to listen on all network interfaces
app.Urls.Add("http://0.0.0.0:5000");

// Enable serving static files from wwwroot folder
app.UseStaticFiles();

app.Run();