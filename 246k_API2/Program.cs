namespace _246k_API2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

         //   builder.WebHost.UseUrls("http://172.16.0.13:5555"); // для доступности во всей сети


            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            


            app.MapControllers();

            app.Run();
        }
    }
}
