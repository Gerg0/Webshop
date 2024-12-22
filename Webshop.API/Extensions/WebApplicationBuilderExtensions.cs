using Serilog;

namespace Webshop.API.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {

        builder.Services.AddControllers();


        builder.Host.UseSerilog((context, configuration) =>
        {
            configuration
            .ReadFrom.Configuration(context.Configuration);
        });
    }
}
