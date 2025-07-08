using basarsoftProjectBase.SecondTask.Service;

var builder = WebApplication.CreateBuilder(args);

//Birinci Task İçin Controllerleri ekle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPointService,PointServiceImpl>();



var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Birinci Task İçin Burayı eklemeyi unutma Controller 
app.MapControllers();

app.Run();

