using FirstAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(); // you need to add this line in to enable .NET to share the json file

builder.Services.AddDbContext<FoodContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:FoodConnection"])
);

builder.Services.AddScoped<IFoodRepository, EFFoodRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(p => p.WithOrigins("http://localhost:3000")); //specify who its OK to talk with here

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
