using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudStoreProcedure.Startup))]
namespace crudStoreProcedure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
