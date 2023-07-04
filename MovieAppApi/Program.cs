using MovieAppApi.Models;
using MovieAppApi.Data;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MoviesRepositoryContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));
});

builder.Services.AddCors(options =>
    {
        options.AddPolicy("MyCorsPolicy", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
    });



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

app.UseCors("MyCorsPolicy");

app.Run();
