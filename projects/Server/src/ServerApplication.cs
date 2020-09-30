using Ubercube.Core;

namespace Ubercube.Server
{
    public class ServerApplication : Application
    {
        public override void Init()
        {
            AppHost.SetTargetFps(0);
            AppHost.SetTargetUps(60);
        }

        public override void Update(float delta)
        {
            
        }

        public override void Render(float delta)
        {
            
        }

        public override void Stop()
        {
            
        }

        public override void Dispose()
        {
            
        }
    }
}