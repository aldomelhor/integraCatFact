using IntegraCatfactApi.Aplicacao.AutoMapper;
using IntegraCatfactApi.Aplicacao.Rest;
using IntegraCatfactApi.Aplicacao.Services;
using IntegraCatFactApi.Aplicacao.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IBreedsService, BreedsService>();
builder.Services.AddSingleton<ICatfactApi, CatfactApiRest>();
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
