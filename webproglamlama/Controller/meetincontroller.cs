var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute(
    name :"default",
    pattern:"{controller = home }/{action _ index }/ { id?}"
);

app.Run();