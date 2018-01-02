using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bar_chart.Startup))]
namespace bar_chart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
