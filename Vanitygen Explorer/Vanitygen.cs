#region

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace Vanitygen_Explorer
{
    /* Example key generation output:
     * 
     * Pattern: DTE
     * Address: DTETWMkqhVnbMFX7w69ASF1fRY6Wno6DFk
     * Privkey: 6KufAdoUSs8x8JQNzNBPr5Fd6v4m7w8mK4YBaW3SBq5A95UP2ey
     * 
     * Example hash rate output:
     * 
     * [65.95 Kkey/s][total 10756][Found 4] 
     * 
    */

    internal class Vanitygen : IDisposable
    {
        private static readonly Regex _rateRegex = new Regex(@"\[([^]]*)\]", RegexOptions.Compiled);

        private readonly string _executablePath;
        private Process _process;

        public Vanitygen(string executablePath)
        {
            _executablePath = executablePath;
        }

        public ISynchronizeInvoke SynchronizingObject { get; set; }

        #region Events

        public event EventHandler<VanitygenUpdateEventArgs> HashRateChanged;
        public event EventHandler Stopped;
        public event EventHandler<AddressGeneratedEventArgs> AddressGenerated;

        #endregion

        public void Start(int version, string pattern, bool regex = false, bool caseInsensitive = false,
            bool keepPattern = false, int threads = 0, string outputFile = null)
        {
            var argBuilder = new StringBuilder();

            argBuilder.Append("-X " + version);

            if (regex)
                argBuilder.Append(" -r");
            if (caseInsensitive)
                argBuilder.Append(" -i");
            if (keepPattern)
                argBuilder.Append(" -k");
            if (threads > 0)
                argBuilder.Append(" -t " + threads);
            if (!string.IsNullOrEmpty(outputFile))
                argBuilder.Append(" -o " + outputFile);

            argBuilder.Append(" " + pattern);

            var psi = new ProcessStartInfo()
            {
                FileName = _executablePath,
                Arguments = argBuilder.ToString(),
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            _process = new Process {EnableRaisingEvents = true, SynchronizingObject = SynchronizingObject,};

            _process.Exited += _process_Exited;
            _process.OutputDataReceived += _process_OutputDataReceived;
            _process.StartInfo = psi;
            _process.Start();

            _process.BeginOutputReadLine();
        }

        public void Stop()
        {
            if (_process != null)
            {
                _process.CancelOutputRead();

                if (!_process.HasExited)
                    _process.Kill();

                if (Stopped != null)
                    Stopped(this, EventArgs.Empty);
            }
        }

        public bool IsRunning()
        {
            return _process != null && !_process.HasExited;
        }

        #region Process Events

        private string _workingAddress, _workingKey;
        private string _workingPattern;

        private void _process_Exited(object sender, EventArgs e)
        {
            if (Stopped != null)
                Stopped(this, EventArgs.Empty);
        }

        private void _process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;

            //hash rate
            if (e.Data.StartsWith("["))
            {
                var regexMatches = _rateRegex.Matches(e.Data);

                if (regexMatches.Count > 0)
                {
                    var rate = regexMatches[0].Groups[1].Value;
                    var total = long.Parse(regexMatches[1].Groups[1].Value.Remove(0, 6));

                    if (HashRateChanged != null)
                        HashRateChanged(this, new VanitygenUpdateEventArgs(rate, total));
                }
            }

                //generation result
            else if (e.Data.StartsWith("Pattern") || _workingPattern != null)
            {
                var split = e.Data.Split(':');
                var info = split[0];
                var value = split[1].Trim();

                if (info == "Pattern")
                    _workingPattern = value;
                else if (info == "Address")
                    _workingAddress = value;
                else if (info == "Privkey")
                {
                    _workingKey = value;

                    var result = new VanitygenResult(_workingPattern, _workingAddress, _workingKey);

                    if (AddressGenerated != null)
                        AddressGenerated(this, new AddressGeneratedEventArgs(result));

                    _workingPattern = _workingAddress = _workingKey = null;
                }
            }
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            if (_process != null)
                _process.Dispose();
        }

        #endregion
    }
}