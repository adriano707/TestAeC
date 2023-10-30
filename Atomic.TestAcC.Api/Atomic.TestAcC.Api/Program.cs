using Atomic.Test.AeC.Domain.Repositories;
using Atomic.Test.AeC.Domain.Service;
using Atomic.TestAeC.Data;
using Atomic.TestAeC.Data.REpository;
using TestAeC.ApiBrasil;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDatabaseConfiguration(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IClimateConsultation, ClimateConsultation>();

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped<IAirportService, AirportService>();
builder.Services.AddScoped<ICityService, CityService>();

builder.Services.AddScoped<IClimateConsultation, ClimateConsultation>();

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
