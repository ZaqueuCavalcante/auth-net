namespace AuthNet;

public class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public static void Configure(IApplicationBuilder app)
    {
        app.UseRouting();

        // app.UseAuthentication();
        // app.UseAuthorization();

        app.UseEndpoints(options => options.MapControllers());
    }
}
