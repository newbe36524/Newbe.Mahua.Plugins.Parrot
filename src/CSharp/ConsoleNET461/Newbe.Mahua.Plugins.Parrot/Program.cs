using System;
using Nancy.Hosting.Self;

namespace Newbe.Mahua.Plugins.Parrot
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:65321")))
            {
                host.Start();
                Console.WriteLine("Started! press Enter to exit.");
                Console.ReadLine();
            }
        }
    }
}