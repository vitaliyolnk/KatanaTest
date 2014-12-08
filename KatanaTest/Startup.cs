using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KatanaTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            
            app.Run(context =>
            {
                if (context.Request.Path.Value == "/fail")
                {
                    throw new Exception("Random exception");
                }

                context.Response.ContentType = "text/plain";

                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}