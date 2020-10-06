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
            return this.File("wwwroot/vb-net-icon-1.ico", "image/vnd.microsoft.icon");
        }
    }
}
