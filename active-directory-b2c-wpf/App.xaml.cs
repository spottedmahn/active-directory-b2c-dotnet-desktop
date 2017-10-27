using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;

namespace active_directory_b2c_wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string Tenant = "dorfarasB2CTenant.onmicrosoft.com";
        private static string ClientId = "6d477a4d-92d7-448f-a1b1-f009d27d246f";
        public static string PolicySignUpSignIn = "b2c_1_SiUpIn";
        public static string PolicyEditProfile = "b2c_1_edit_profile";
        public static string PolicyResetPassword = "b2c_1_reset";

        //public static string[] ApiScopes = { "https://fabrikamb2c.onmicrosoft.com/demoapi/demo.read" };
        //public static string ApiEndpoint = "https://fabrikamb2chello.azurewebsites.net/hello";

        // this works
        //public static string[] ApiScopes = { "https://dorfarasB2CTenant.onmicrosoft.com/helloapi/read_name" };
        //public static string ApiEndpoint = "http://localhost:55259/hello";

        public static string[] ApiScopes = { "https://dorfarasB2CTenant.onmicrosoft.com/helloapi2/another_scope" };
        public static string ApiEndpoint = "http://localhost:62875/api/values";

        private static string BaseAuthority = "https://login.microsoftonline.com/tfp/{tenant}/{policy}/oauth2/v2.0/authorize";
        public static string Authority = BaseAuthority.Replace("{tenant}", Tenant).Replace("{policy}", PolicySignUpSignIn);
        public static string AuthorityEditProfile = BaseAuthority.Replace("{tenant}", Tenant).Replace("{policy}", PolicyEditProfile);
        public static string AuthorityResetPassword = BaseAuthority.Replace("{tenant}", Tenant).Replace("{policy}", PolicyResetPassword);

        private static PublicClientApplication _clientApp = new PublicClientApplication(ClientId, Authority, TokenCacheHelper.GetUserCache());
        
        public static PublicClientApplication PublicClientApp { get { return _clientApp; } }
    }
}
