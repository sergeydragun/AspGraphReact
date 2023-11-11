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
                    .AddQueryType<VedaVersumBaseQuery>()
                    .AddMutationType<VedaVersumMutation>()
                    .AddSubscriptionType<VedaVersumSubscription>();

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}