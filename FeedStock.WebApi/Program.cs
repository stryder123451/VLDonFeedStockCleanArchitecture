using FeedStock.Persistence.DbContextClass;

var builder = WebApplication.CreateBuilder(args);

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    {
        var context = serviceProvider.GetRequiredService<FeedStockDbContext>()
    }
}





    var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
