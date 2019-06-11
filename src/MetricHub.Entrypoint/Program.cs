using System;
using System.Threading;
using System.Threading.Tasks;

namespace MetricHub.Entrypoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            Task.Factory.StartNew(() => { EventFlow.Monitor(cts.Token); });
            //IisConfigHelper.UpdateEnvironmentVariables();
            IisMonitor.Monitor();
            cts.Cancel();
        }
    }
}
