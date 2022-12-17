using Microsoft.EntityFrameworkCore;
using Zaan.Models;
using Zaan.Models.Model;
using Zaan.Repositories;
using Zaan.Repositories.Auth;
using Zaan.Repositories.Customers;
using Zaan.Repositories.Salers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IBase<Saler>, SalerRepository>();
builder.Services.AddScoped<ISalerRepository, SalerRepository>();
builder.Services.AddScoped<IBase<Customer>, CustomerRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddDbContext<ZaanContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ZaanContext")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");
app.UseAuthorization();

app.MapControllers();

app.Run();
