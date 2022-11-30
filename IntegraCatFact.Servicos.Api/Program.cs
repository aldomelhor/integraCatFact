using IntegraCatfact.Aplicacao.AutoMapper;
using IntegraCatFact.Aplicacao.Interfaces;
using IntegraCatfact.Aplicacao.Rest;
using IntegraCatfact.Aplicacao.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IBreedsService, BreedsService>();
builder.Services.AddSingleton<ICatFactApi, CatFactApiRest>();
builder.Services.AddAutoMapper(typeof(BreedsMapping));

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
