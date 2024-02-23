using API_Auction_ReactNET.Extensions;
using API_Auction_ReactNET.Hubs;
using BusinessLayer.Abstraction;
using BusinessLayer.Concrete;
using CoreLayer.Models;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddSwaggerCollection(builder.Configuration);
builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddCors();
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter=true);
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSignalR();
builder.Services.AddScoped(typeof(ApiResponse));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x=>x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin=>true).AllowCredentials());
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseStaticFiles();
app.MapHub<BidUpdateHub>("/BidUpdate/Hub");
app.MapControllers();

app.Run();
