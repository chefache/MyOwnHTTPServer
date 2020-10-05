using SUS.HTTP;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMvcApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHttpServer server = new HttpServer();

            server.AddRoute("/", HomePage);
            server.AddRoute("/favicon.ico", Favicon);
            server.AddRoute("/about", About);
            server.AddRoute("/user/login", LogIn);
            await server.StartAsync(80);
        }

        static HttpResponse HomePage(HttpRequest request)
        {
            var responseHtml = "<h1>Welcome!</h1>" +
                        request.Headers.FirstOrDefault(x => x.Name == "User-Agent")?.Value;
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }

        private static HttpResponse Favicon(HttpRequest arg)
        {
            var fileBites = File.ReadAllBytes("wwwroot/vb-net-icon-1.ico");
            var response = new HttpResponse("image/vnd.microsoft.icon", fileBites);
            return response;
        }

        static HttpResponse About(HttpRequest request)
        {

            var responseHtml = "<h1>About...</h1>" +
                        request.Headers.FirstOrDefault(x => x.Name == "User-Agent")?.Value;
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }

        static HttpResponse LogIn(HttpRequest request)
        {
            var responseHtml = "<h1>Log in...</h1>" +
                        request.Headers.FirstOrDefault(x => x.Name == "User-Agent")?.Value;
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }
    }
}
