using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyFirstMvcApp.Controllers
{
    public class UsersController: Controller
    {
        public HttpResponse LogIn(HttpRequest request)
        {
            var responseHtml = "<h1>Log in...</h1>";
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }

        public HttpResponse Register(HttpRequest request)
        {
            var responseHtml = File.ReadAllText("Views/Users/Register.html");
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }
    }
}
