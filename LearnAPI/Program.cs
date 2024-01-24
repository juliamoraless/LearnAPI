using System.Reflection;
using LearnAPI.Application.Profiles;
using LearnAPI.Configuration;
using LearnAPI.Infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration;

builder.Services.AddDbContext<LearnContext>(options => 
    options.UseSqlServer(Configuration.GetConnectionString("Default")));

builder.Services.AddAutoMapper(typeof(StudentProfile));

builder.Services.ResolveDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
