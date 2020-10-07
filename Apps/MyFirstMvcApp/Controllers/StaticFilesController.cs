using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFirstMvcApp.Controllers
{
    public class StaticFilesController : Controller
    {
        public HttpResponse Favicon(HttpRequest arg)
        {
            return this.File("wwwroot/vb-net-icon-1.ico", "image/vnd.microsoft.icon");
        }

        internal HttpResponse BootstrapCss(HttpRequest arg)
        {
            return this.File("wwwroot/css/bootstrap.min.css", "text/css");
        }

        internal HttpResponse CustomCss(HttpRequest arg)
        {
            return this.File("wwwroot/css/custom.css", "text/css");
        }

        internal HttpResponse CustomJs(HttpRequest arg)
        {
            return this.File("wwwroot/js/custom.js", "text/javascript");
        }

        internal HttpResponse BootstrapJs(HttpRequest arg)
        {
            return this.File("wwwroot/js/bootstrap.bundle.min.js", "text/javascript");
        }
    }
}
