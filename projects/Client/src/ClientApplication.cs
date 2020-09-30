using Ubercube.Core;

namespace Ubercube.Client
{
    public class ClientApplication : Application
    {
        public override void Init()
        {
            AppHost.SetTargetFps(-1);
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