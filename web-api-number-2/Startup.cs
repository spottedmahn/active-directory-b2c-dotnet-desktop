using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(web_api_number_2.Startup))]
namespace web_api_number_2
{

    public partial class Startup
    {
        // The OWIN middleware will invoke this method when the app starts
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth defined in other part of the class
            ConfigureAuth(app);
        }
    }
}