using CleanArchitecture.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
{
    builder.Services.RegisterApplicationServices()
                    .RegisterInfrastructureServices()
                    .RegisterPersistenceServices(builder.Configuration)
                    .RegisterPresentationServices();
}
var app = builder.Build();
{
    app.UseRouting();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}