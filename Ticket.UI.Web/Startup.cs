using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ticket.UI.Web.Startup))]
namespace Ticket.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
