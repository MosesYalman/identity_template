using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identity_template.Startup))]
namespace identity_template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthentificationOption()
                { AuthenticationType=DefaultAuthentificationTypes.
                    ApplicationCookie.LoginPath=new PathString("/Account/Login")});
            ConfigureAuth(app);
        }
    }
}
