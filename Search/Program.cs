using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Search.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SeekifyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SeekifyContext") ?? throw new InvalidOperationException("Connection string 'SeekifyContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(); // Make sure you call this previous to AddMvc
builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

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

// global cors policy
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials()); // allow credentials

app.Run();
