using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:5173")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOcelot();

var app = builder.Build();

app.UseCors("AllowFrontend");

app.MapGet("/", () => "API Gateway Running on Port: 5000");

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseWhen(
    context => context.Request.Path != "/",
    appBuilder =>
    {
        appBuilder.UseOcelot().Wait();
    }
);

// await app.UseOcelot();

app.Run();
