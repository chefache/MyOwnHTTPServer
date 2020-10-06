using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SUS.MvcFramework
{
    public abstract class Controller
    {
        public HttpResponse View([CallerMemberName]string viewPath = null)
        {
            var responseHtml = System.IO.File.ReadAllText(
                "Views/" + 
                this.GetType().Name.Replace("Controller", string.Empty) + 
                "/" + 
                viewPath + ".html");
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }


        public HttpResponse File(string filePath, string contentType)
        {
            var fileBites = System.IO.File.ReadAllBytes(filePath);
            var response = new HttpResponse(contentType, fileBites);
            return response;
        }
    }
}
