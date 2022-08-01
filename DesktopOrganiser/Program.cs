using DesktopOrganiser;
using DesktopOrganiser.Organizer;
using Microsoft.Extensions.DependencyInjection;

namespace DesktopOrganiser
{


    public class Program
    {
     

        public static void Main(string[] args)
        {

            IServiceProvider services = new ServiceCollection()
            .AddTransient<Organize>()
            .AddTransient<MainMenu>()
            .AddTransient<Start>()
            .BuildServiceProvider();
            Start s = services.GetService<Start>();

            s.Run();

        }

    }



}

