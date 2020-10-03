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
            var server = new HttpServer();

            server.AddRoute("/", HomePage);
            server.AddRoute("/about", About);
            server.AddRoute("/user/login", LogIn);

            server.Start(80);
        }

        static HttpResponse HomePage(HttpRequest request)
        {
            
        }
        static HttpResponse About(HttpRequest request)
        {

        }
        static HttpResponse LogIn(HttpRequest request)
        {

        }
    }
}
