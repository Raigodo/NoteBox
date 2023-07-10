using NoteBox.Api.Contracts;
using System.Net;

namespace NoteBox.Api.Middleware;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            var error = new Error
            {
                StatusCode = context.Response.StatusCode.ToString(),
                Message = ex.Message,
            };
            await context.Response.WriteAsync(error.ToString());
        }
    }
}
