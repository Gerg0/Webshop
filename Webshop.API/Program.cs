using Serilog;
using Webshop.API.Extensions;
using Webshop.API.Middleware;
using Webshop.Application.Extensions;
using Webshop.Domain.Entities;
using Webshop.Infrastructure.Extensions;
using Webshop.Infrastructure.Seeders;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddPresentation();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

var scope = app.Services.CreateScope();
var seeders = scope.ServiceProvider.GetServices<ISeeder>();
foreach (var seeder in seeders)
{
    await seeder.Seed();
}


app.UseSerilogRequestLogging();


// Configure the HTTP request pipeline.

app.UseMiddleware<ErrorHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("api/identity").WithTags("Identity").MapIdentityApi<User>();

app.UseAuthorization();

app.MapControllers();

app.Run();
