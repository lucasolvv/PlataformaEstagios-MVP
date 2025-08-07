namespace PlataformaEstagios.Application
{
    public class DependecyInjectionExtension
    {
       public static void AddAplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));
        }

    }
}
