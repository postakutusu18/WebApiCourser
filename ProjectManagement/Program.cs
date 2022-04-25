using Contracts;
using LoggerService;
using NLog;
using ProjectManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);


//Nlog Configuration
LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(),"/nlog.config"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Nlog Dependenecy
//builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

//builder.Services.AddCors();
builder.Services.ConfigureCors();//extension method cors
builder.Services.ConfigureLoggerManager();//extension method logger


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

//app.UseCors(x=>x.AllowAnyOrigin());//tüm orginlerden gelen istekleri kabul et.
app.UseCors("CorsPolicy");
app.Run();
