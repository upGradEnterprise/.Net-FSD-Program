
using WebApplication4.CustomMiddlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Enables detailed error page
}

app.UseSwagger();
app.UseSwaggerUI();


// Registration
app.UseMiddleware<ApiKeyMiddleware>();
app.UseMiddleware<IpBlockingMiddleware>();      // https://127.0.0.1:7003/api/Products

app.MapControllers();


app.Run();