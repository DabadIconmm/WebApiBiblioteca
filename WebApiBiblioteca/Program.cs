using Ejercicio_Sesi?n_1;
using Microsoft.EntityFrameworkCore;

//Comentario de Codigo: Ejercicio 14

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("defaultConnection"); //nos referimos a la conexion con appsetting.Development.json
// Registramos en el sistema de inyecci?n de dependencias de la aplicaci?n el ApplicationDbContext
builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
            opciones.UseSqlServer(connectionString));

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
