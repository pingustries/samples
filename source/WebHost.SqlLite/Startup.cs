﻿using Microsoft.Owin;
using Owin;
using PingOwin.Core.Frontend;

[assembly: OwinStartup(typeof(WebHost.SqlLite.Startup))]

namespace WebHost.SqlLite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UsePingOwinFrontend();
        }
    }
}
