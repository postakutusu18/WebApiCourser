using Contracts;
using LoggerService;

namespace ProjectManagement.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => 
                
                builder.AllowAnyOrigin()//bütün kaynaklardan gelen istekleri kabul et.
                .AllowAnyMethod() //tüm methodları kabul et.
                .AllowAnyHeader()//HTTP headerları kabul et
                );
            });
        }

        public static void ConfigureLoggerManager(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager,LoggerManager>();
        }
    }
}
