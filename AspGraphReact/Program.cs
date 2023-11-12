using AspGraphReact.API;
using Common;
using AutoMapper;
using AspGraphReact.Services;

namespace AspGraphReact
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                    .AddGraphQLServer()
                    .AddInMemorySubscriptions()
                    .AddQueryType<InfoQuery>()
                    .AddMutationType<InfoMutation>()
                    .AddSubscriptionType<InfoSubcription>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            var connectionString = builder.Configuration.GetConnectionString(Constants.ConfigurationName);

            builder.Services.ConfigureDbContext(connectionString);
            builder.Services.ConfigureCardInfoService();
            builder.Services.ConfigureUserService();
            builder.Services.ConfigureUnitOfWork();

            var app = builder.Build();

            app.UseWebSockets()
               .UseRouting()
               .UseEndpoints(endpoints =>
               {
                   endpoints.MapGraphQL();
               });

            app.Run();
        }
    }
}