using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SUS.MvcFramework
{
    public static class Host
    {
        public static async Task CreateHostAsync(List<Route> routeTable, int port = 80)
        {
            IHttpServer server = new HttpServer();

            foreach (var route in routeTable)
            {
                server.AddRoute(route.Path, route.Action);
            }

            await server.StartAsync(port);
        }
    }
}
