using System.Diagnostics;

namespace Ubs.Excercise.Test
{
    internal class Given_a_process_runner
    {
        public static string Give_a_sentence_stats_calculator(string arguments)
        {
            const string processName = "Ubs.Excercise.exe";
            var process = new Process {StartInfo = new ProcessStartInfo(processName){RedirectStandardOutput = true, Arguments = arguments, UseShellExecute = false}};
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
    }
}