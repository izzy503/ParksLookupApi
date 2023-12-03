using ParkLookupApi.Models;
using Microsoft.EntityFrameworkCore;

var webAppBuilder = WebApplication.CreateBuilder(args);

webAppBuilder.Services.AddControllers();

webAppBuilder.Services.AddDbContext<ParkLookupApiContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(
            webAppBuilder.Configuration["ConnectionStrings:DefaultConnection"],
            ServerVersion.AutoDetect(webAppBuilder.Configuration["ConnectionStrings:DefaultConnection"])
        )
    );
webAppBuilder.Services.AddEndpointsApiExplorer();
webAppBuilder.Services.AddSwaggerGen();

var application = webAppBuilder.Build();

if (application.Environment.IsDevelopment())
{
  application.UseSwagger();
  application.UseSwaggerUI();
}
else
{
  application.UseHttpsRedirection();
}
application.UseHttpsRedirection();

application.UseAuthorization();

application.MapControllers();

application.Run();
