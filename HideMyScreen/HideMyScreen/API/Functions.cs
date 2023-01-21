using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace HideMyScreen.API
{
    internal class Functions
    {
        public static void KillCurrentProcess()
        {
            var CurrentProcess = Native.Functions.GetForegroundProcess();
            if (CurrentProcess != null)
            {
                try
                {
                    CurrentProcess.Kill();
                }
                catch
                {
                }
            }
        }

        public static void OpenProcess(string PE)
        {
            if (PE.EndsWith(".exe"))
            {
                try
                {
                    Process.Start(PE);
                }
                catch
                {
                }
            }
        }
        
        private static readonly string[] Processes = new string[] { "notepad.exe", "calc.exe", "mspaint.exe" };

        public static string GetRandomProcess()
        {
            return Processes[new Random().Next(0, Processes.Length)];
        }
    }
}
