
using Dotnet_Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("MyApp");
builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlServer(connectionString));


IHost host = builder.Build();
host.Run();