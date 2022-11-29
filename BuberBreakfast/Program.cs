using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    //Every time IBreakfastService is referenced, Make a new Breakfastservice object and use it.
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
}


var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
