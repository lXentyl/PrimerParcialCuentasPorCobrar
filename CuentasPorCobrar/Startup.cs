using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CuentasPorCobrar.Startup))]
namespace CuentasPorCobrar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
