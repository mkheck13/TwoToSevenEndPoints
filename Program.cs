using TwoToSevenEndPoints.Services.Madlib;
using TwoToSevenEndPoints.Services.OddOrEven;
using TwoToSevenEndPoints.Services.ReverseItAlpha;
using TwoToSevenEndPoints.Services.ReverseItNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOddService, OddService>();
// builder.Services.AddScoped<IMadService, MadService>();
// builder.Services.AddScoped<IRiaService, RiaService>();
// builder.Services.AddScoped<IRinService, RinService>();

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
