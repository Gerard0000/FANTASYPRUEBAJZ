using FANTASYPRUEBAJZ.backend.Data;
using FANTASYPRUEBAJZ.backend.Repositories.Implementations;
using FANTASYPRUEBAJZ.backend.Repositories.Interfaces;
using FANTASYPRUEBAJZ.backend.UnitofWork.Implementations;
using FANTASYPRUEBAJZ.backend.UnitofWork.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=LocalConnection"));

//Inyectamos para los controladores genericos y funcione por repository y genericunitofwork
builder.Services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitofWork<>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

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

app.UseCors(x => x
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true)
.AllowCredentials());

app.Run();