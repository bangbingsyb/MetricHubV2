using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Diagnostics.EventFlow;

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
