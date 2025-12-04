using eCommerce.API.Middlewares;
using eCommerce.Core;
using eCommerce.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure services to the container.
builder.Services.AddInfrastructure();
// add Core services to the container
builder.Services.AddCore();

builder.Services.AddControllers();

var app = builder.Build();


app.UseExceptionHandlingMiddleware();

// Routing
app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();