using System;
using System.Diagnostics;
using System.Threading;

namespace Disco.Profiling
{
    public readonly struct StandardProfiler : IDisposable
    {
        static readonly ThreadLocal<Stopwatch> _stopwatch = new ThreadLocal<Stopwatch>(() => new Stopwatch());

        readonly string _info;

        static StandardProfiler()
        {
            _stopwatch.Value.Start();
        }

        //It doesn't make any sense to profile with two different patterns, either it's trough the main struct
        //or through the Sample method. If both are provided, Sample is basically never used.
        public StandardProfiler(string info)
        {
            _info = info;
        }

        public StandardDisposableSampler Sample(string samplerName, string samplerInfo = null)
        {
            samplerName = samplerName.FastConcat(" - ", _info);
            return new StandardDisposableSampler(samplerName, _stopwatch.Value);
        }

        public StandardDisposableSampler Sample<T>(T samplerName, string samplerInfo = null)
        {
            string sampleName = samplerName.ToString().FastConcat(" - ", _info);
            return new StandardDisposableSampler(sampleName, _stopwatch.Value);
        }

        public void Dispose()
        { }
    }

    public class StandardDisposableSampler : IDisposable
    {
        readonly Stopwatch _watch;
        readonly long _startTime;
        readonly string _samplerName;

        public StandardDisposableSampler(string samplerName, Stopwatch stopwatch)
        {
            _watch = stopwatch;
            _startTime = stopwatch.ElapsedTicks;
            _samplerName = samplerName;
        }

        public void Dispose()
        {
            var stopwatchElapsedTicks = (_watch.ElapsedTicks - _startTime);
            string sampleName = _samplerName.FastConcat(" -> ").FastConcat(stopwatchElapsedTicks / 10000.0);
            DiscoLogger.LOG_PROFILER(sampleName);
        }
    }
}
