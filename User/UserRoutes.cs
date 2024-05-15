namespace WebApplication1.User
{
    public static class UserRoutes
    {
        public static void AddUserRoutes(WebApplication app)
        {
            app.MapGet("User", () => "Hello World");
        }
    }
}
