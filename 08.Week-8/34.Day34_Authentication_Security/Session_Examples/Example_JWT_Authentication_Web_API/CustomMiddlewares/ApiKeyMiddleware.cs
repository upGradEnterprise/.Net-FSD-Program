namespace WebApplication4.CustomMiddlewares
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ApiKeyHeaderName = "X-API-KEY";
        private readonly string _expectedApiKey;

        public ApiKeyMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _expectedApiKey = config["MySettings:ApiKey"]; // from appsettings.json
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(ApiKeyHeaderName, out var extractedApiKey)
                || _expectedApiKey != extractedApiKey)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized: API Key missing or invalid.");
                return;
            }

            await _next(context);
        }
    }

    
}
