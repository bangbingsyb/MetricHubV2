using Microsoft.Diagnostics.EventFlow;
using System.Threading;
using System.Threading.Tasks;

namespace MetricHub.Entrypoint
{
    public static class EventFlow
    {
        public static void Monitor(CancellationToken cancellationToken)
        {
            using (var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json"))
            {
                System.Diagnostics.Trace.TraceWarning("EventFlow is working!");
                Task.Delay(Timeout.Infinite, cancellationToken).GetAwaiter().GetResult();
            }
        }
    }
}
