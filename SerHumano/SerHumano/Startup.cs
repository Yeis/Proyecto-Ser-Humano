using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SerHumano.Startup))]
namespace SerHumano
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
