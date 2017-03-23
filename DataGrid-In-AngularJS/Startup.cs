using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataGrid_In_AngularJS.Startup))]
namespace DataGrid_In_AngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseNancy();
        }
    }
}
