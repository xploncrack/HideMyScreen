using System;

namespace HideMyScreen.Conzole
{
    internal class Functions
    {
        public static void WriteColors(string Text, string[] Symbols, ConsoleColor Color)
        {
            Console.ResetColor();
            foreach (var Letter in Text)
            {
                foreach (var Symbol in Symbols)
                {
                    if (Letter.ToString() == Symbol)
                    {
                        Console.ForegroundColor = Color;
                    }
                }
                Console.Write(Letter.ToString());
                Console.ResetColor();
            }
        }
    }
}
