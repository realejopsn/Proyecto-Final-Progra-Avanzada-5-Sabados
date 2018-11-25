using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fidelitas.Proyecto.ArticulosPerdidos.Startup))]
namespace Fidelitas.Proyecto.ArticulosPerdidos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
