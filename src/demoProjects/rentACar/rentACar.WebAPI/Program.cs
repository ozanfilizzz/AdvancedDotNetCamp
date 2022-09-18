using Core.CrossCuttingConcerns.Exceptions;
using rentACar.Application.DependencyResolvers;
using rentACar.Persistence.DependencyResolvers;
using rentACar.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//if (app.Environment.IsProduction())
    app.ConfigureCustomExceptionMiddleware();

app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase();

app.Run();
