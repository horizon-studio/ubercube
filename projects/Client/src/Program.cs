using System;
using Ubercube.Core;

namespace Ubercube.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientApplication app = new ClientApplication();
            ApplicationHost host = new ApplicationHost(app);
            host.Start();
        }
    }
}