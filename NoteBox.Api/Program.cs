using NoteBox.Api.Middleware;
using NoteBox.Application;
using NoteBox.Dal;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDal()
    .AddApplication(builder.Configuration)
    ;

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

app.UseAuthorization();

app.MapControllers();
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.Run();
