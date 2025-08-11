using Scalar.AspNetCore;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
    app.MapOpenApi();
    
    app.MapScalarApiReference();
    
    app.UseHttpsRedirection();

app.MapGet("/time", () =>
    {
        return new
        {
            CurrentTime = DateTime.UtcNow,
            TimeZone = "UTC"
        };
    });

app.Run();

