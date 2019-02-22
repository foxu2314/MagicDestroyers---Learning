using System;

namespace CSharpOOP
{
    public static class Tools
    {
        public static void ColorfulWriteLines(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
