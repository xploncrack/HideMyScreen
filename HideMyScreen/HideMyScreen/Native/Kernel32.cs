using System;
using System.Runtime.InteropServices;

namespace HideMyScreen.Native
{
    internal class Kernel32
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
}
