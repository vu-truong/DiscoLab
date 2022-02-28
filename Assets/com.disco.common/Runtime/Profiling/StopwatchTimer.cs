
using System;
using System.Diagnostics;

namespace Disco.Profiling
{
    public class StopwatchTimer : IDisposable
    {
        private readonly string _taskName;
        private readonly Stopwatch _stopWatch;

        public StopwatchTimer(string taskName)
        {
            _taskName = taskName;
            //Debug.Log("Starting Task " + _taskName);
            _stopWatch = new Stopwatch();
            _stopWatch.Start();
        }

        public void Dispose()
        {
            _stopWatch.Stop();
            //Debug.Log("Finished Task " + _taskName + " in " + _stopWatch.Elapsed.TotalSeconds + " s");
        }
    }
}
