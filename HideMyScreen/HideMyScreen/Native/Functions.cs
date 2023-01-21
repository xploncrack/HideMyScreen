using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HideMyScreen.Native
{
    internal class Functions
    {
        public static bool KeyIsDown(Keys THE_KEY_YOU_WANT_TO_USE_NIGGA)
        {
            return User32.GetAsyncKeyState(THE_KEY_YOU_WANT_TO_USE_NIGGA) < 0;
        }

        public static Process GetForegroundProcess()
        {
            var WindowHandle = User32.GetForegroundWindow();
            if (WindowHandle != IntPtr.Zero)
            {
                uint ID;
                User32.GetWindowThreadProcessId(WindowHandle, out ID);
                return Process.GetProcessById((int)ID);
            }
            return null;
        }

        public static void HideConsole()
        {
            var Handle = Kernel32.GetConsoleWindow();
            if (Handle != IntPtr.Zero)
            {
                User32.ShowWindow(Handle, 0);
            }
        }
    }
}
