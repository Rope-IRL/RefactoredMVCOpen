using RefactoredMVC.API.Middleware.Initializers;

namespace RefactoredMVC.API.Helpers
{
    public static class AddDataIfEmpty
    {
        public static IApplicationBuilder UseAddData(this IApplicationBuilder app)
        {
            return app.UseMiddleware<DbInitializer>();
        }
    }
}
