using Microsoft.IdentityModel.Tokens;
using Owin;
using System;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin;
using HelloAPI.App_Start;
using System.Configuration;

namespace HelloAPI
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}