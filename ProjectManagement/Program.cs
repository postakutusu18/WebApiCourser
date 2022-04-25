using ProjectManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddCors();
builder.Services.ConfigureCors();//extension method
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
