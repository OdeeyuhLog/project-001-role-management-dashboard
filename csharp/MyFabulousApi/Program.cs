using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MyFabulousApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder
    .Services
    .AddSwaggerGen(c =>
    {
        c.SwaggerDoc(
            "v1",
            new OpenApiInfo
            {
                Title = "Todo App Main API",
                Description = "This keeps track of the users todo tasks.",
                Version = "v1"
            }
        );
    });

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer()
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My Fabulous API v1");
        options.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
