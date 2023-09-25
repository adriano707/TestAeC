using User.Data;
using User.Data.Repository;
using User.Domain.Entities.Repository;
using User.Domain.Entities.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseConfiguration(builder.Configuration);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPhoneService, PhoneService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IOccupationService, OccupationService>();

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
