using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewJsTree.Startup))]
namespace NewJsTree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
