using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoteBooks.Startup))]
namespace NoteBooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
