using Microsoft.Data.SqlClient;
using System.Net;
using System.Text.Json;
using TaskNotissimus.Application.Common.Exceptions;

namespace TaskNotissimus.Web.Middleware
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;
            var exMessage = exception.Message;
            if (exception.InnerException != null && exception.InnerException is SqlException)
            {
                exception = exception.InnerException;
            }
            switch (exception)
            {
                case NotFoundException:
                    code = HttpStatusCode.NotFound;
                    break;
                case SqlException:
                    exMessage = "Произошла ошибка при работе с базой данных.";
                    break;
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            if (result == string.Empty)
            {
                result = JsonSerializer.Serialize(new { error = exMessage });
            }

            return context.Response.WriteAsync(result);
        }
    }
}
