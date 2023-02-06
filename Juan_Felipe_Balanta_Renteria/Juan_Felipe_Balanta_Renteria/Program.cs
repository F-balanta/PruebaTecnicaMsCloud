using Juan_Felipe_Balanta_Renteria.DataContext;
using Juan_Felipe_Balanta_Renteria.Servicios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TableroContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDB"));
});
// Añado el servicio
builder.Services.AddScoped<ITableroServices, TableroServices>();

builder.Services.AddCors(x => x.AddPolicy("MyCors",
    builder =>
    {
        builder
        .WithOrigins("http://localhost:4200", "https://localhost:4200")
        .SetIsOriginAllowedToAllowWildcardSubdomains()
        .AllowAnyHeader()
        .AllowCredentials()
        .AllowAnyMethod();
        //builder
        //    .WithOrigins("*")
        //    .AllowAnyMethod()
        //    .AllowAnyMethod();
    }));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
