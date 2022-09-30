using Auto.Ecommer.Aplication.Interface;
using Auto.Ecommerce.Aplication.Main;
using Auto.Ecommerce.Domain.Core;
using Auto.Ecommerce.Domain.Interface;
using Auto.Ecommerce.Infrastructura.Data;
using Auto.Ecommerce.Infrastucture.Interface;
using Auto.Ecommerce.Infrastucture.Repository;
using Auto.Ecommerce.Transversal.Common;
using Auto.Ecommerce.Transversal.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(x => x.AddProfile(new MappingProfile()));
builder.Services.AddMvc();
builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>();
builder.Services.AddScoped<ICustomerAplication, CustomerAplicattion>();
builder.Services.AddScoped<ICustomerDomain, CustomerDomain>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
