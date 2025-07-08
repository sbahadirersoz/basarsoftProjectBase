var builder = WebApplication.CreateBuilder(args);

//Controllerleri ekle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Burayı eklemeyi unutma Controller için
app.MapControllers();

app.Run();

