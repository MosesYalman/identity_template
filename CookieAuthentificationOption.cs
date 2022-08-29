using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;

namespace identity_template
{
    internal class CookieAuthentificationOption : CookieAuthenticationOptions
    {
        public PathString AuthenticationType { get; set; }
    }
}