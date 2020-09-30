using System;
using Ubercube.Core;

namespace Ubercube.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerApplication app = new ServerApplication();
            ApplicationHost host = new ApplicationHost(app);
            host.Start();
        }
    }
}