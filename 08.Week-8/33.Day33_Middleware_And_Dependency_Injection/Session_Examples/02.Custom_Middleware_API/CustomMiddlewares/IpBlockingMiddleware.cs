namespace WebApplication4.CustomMiddlewares
{
    public class IpBlockingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly HashSet<string> _blockedIps;

        public IpBlockingMiddleware(RequestDelegate next)
        {
            _next = next;
            _blockedIps = new HashSet<string> { "192.168.1.10", "10.0.0.5" }; // Example blocked IPs
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var remoteIp = context.Connection.RemoteIpAddress?.ToString();

            if (_blockedIps.Contains(remoteIp ?? ""))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Forbidden: Your IP is blocked.");
                return;
            }

            await _next(context);
        }
    } 

}
