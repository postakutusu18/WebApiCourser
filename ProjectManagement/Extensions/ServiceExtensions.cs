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
    }
}
