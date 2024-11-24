using Domain.Interface;
using Persistence.Context;
using Persistence.Repository;
using System;
using Microsoft.EntityFrameworkCore;
using log4net.Config;
using log4net;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly); // register ad
});
builder.Services.AddScoped<IGym_User_MasterRepository, Gym_User_MasterRepository>();
builder.Services.AddScoped<IGymMemberRepository,GymMemberRepository>();
builder.Services.AddScoped<IGymAdminMasterRepository,GymAdminMasterRepository>();
// Configure log4net
log4net.GlobalContext.Properties["LogDirectory"] = Environment.CurrentDirectory;
builder.Services.AddSingleton<ILog>(_ => LogManager.GetLogger(typeof(Program)));
XmlConfigurator.Configure(new FileInfo(Path.Combine(Environment.CurrentDirectory, "/Middleware/Log4Net.config")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
