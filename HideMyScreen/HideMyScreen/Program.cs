using System;
using System.Threading;
using System.Windows.Forms;

namespace HideMyScreen
{
    internal class Program
    {
        static void Main(string[] _) => Script();

        static void Script()
        {
            Console.Title = "We didn't start the fire, it was always burning since the world's been turning!";
            Console.ForegroundColor = ConsoleColor.Red;
            Conzole.Functions.WriteColors("Press [ESC] key to switch/hide your process!\nThis window will hide in 5 seconds...", new string[] { "[", "]" }, ConsoleColor.Magenta);
            Thread.Sleep(3500); // <-- tHaTs NoT fIvE sEcOnDs!!!
            Native.Functions.HideConsole();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    if (!Native.Functions.KeyIsDown(Keys.Escape))
                    {
                        Thread.Sleep(100);
                        continue;
                    }
                    API.Functions.KillCurrentProcess();
                    API.Functions.OpenProcess(API.Functions.GetRandomProcess());
                    Thread.Sleep(250);
                }
            }).Start();
            Console.ReadLine();
        }
    }
}
