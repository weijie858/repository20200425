using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Resources;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identityserverApp.Startup))]
namespace identityserverApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Map("/lym", lymapp =>
            //{

            //    var factory = new IdentityServerServiceFactory()
            //    .UseInMemoryClients(Client.Get())
            //    .UseInMemoryScopes(Scopes.Get())
            //    .UserInMemoryUsers(Users.Get());

            //    lymapp.UseIdentityServer(new IdentityServer3.Core.Configuration.IdentityServerOptions
            //    {
            //        SiteName = "SSO授权验证站点",
            //        //EnableWelcomePage = true,
            //        SigningCertificate = Certificate.Get(),
            //        Factory = factory,
            //        RequireSsl = false
            //    });

            //});
            ConfigureAuth(app);
        }
    }
}
