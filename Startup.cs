using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseConcepts3.Startup))]
namespace DatabaseConcepts3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
