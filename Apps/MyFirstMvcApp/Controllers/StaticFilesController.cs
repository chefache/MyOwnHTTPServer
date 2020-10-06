using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstMvcApp.Controllers
{
    public class StaticFilesController: Controller
    {
        public HttpResponse Favicon(HttpRequest arg)
        {
            var fileBites = File.ReadAllBytes("wwwroot/vb-net-icon-1.ico");
            var response = new HttpResponse("image/vnd.microsoft.icon", fileBites);
            return response;
        }
    }
}
