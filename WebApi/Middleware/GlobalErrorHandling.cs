using System.Data;
using System.Net;
using System.Text.Json;
using WebApi.Exceptions;

namespace WebApi.Middleware
{
    public class GlobalErrorHandling
    {
        private readonly RequestDelegate _next;

        public GlobalErrorHandling(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context) {

            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
           
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            HttpStatusCode statusCode;
            string stackTrace = string.Empty;
            string message = string.Empty;
            var exceptionType = ex.GetType();


            if (exceptionType == typeof(Exception)) { 
            
                message= ex.Message;
                statusCode = HttpStatusCode.BadRequest;
                stackTrace= ex.StackTrace;
            }
            else
            {
                message = ex.Message;
                statusCode = HttpStatusCode.InternalServerError;
                stackTrace = ex.StackTrace;
            }

            var result = JsonSerializer.Serialize(new { statusCode, message, stackTrace });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            return context.Response.WriteAsync(result);
        }
    }
}
