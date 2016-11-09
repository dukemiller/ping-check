using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ping_check
{
    internal class PingService: IPingService
    {
        private const string Command = "-n 1 216.58.219.46";

        public async Task<string> GetPing()
        {
            var process = new Process
            {
                StartInfo =
                {
                    FileName = "ping",
                    Arguments = Command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            process.Start();
            var result = await process.StandardOutput.ReadToEndAsync();
            return ParseCommandlineText(result);
        }

        private static string ParseCommandlineText(string result)
        {
            try
            {
                return result
                    .Split(new[] { "time=" }, 0)[1]
                    .Split(new[] { " " }, 0)[0]
                    .Split(new[] { "ms" }, 0)[0];
            }

            catch
            {
                return "??";
            }
        }
    }
}
