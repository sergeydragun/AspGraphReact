using AspGraphReact.API;

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

            var app = builder.Build();

            app.Run();
        }
    }
}