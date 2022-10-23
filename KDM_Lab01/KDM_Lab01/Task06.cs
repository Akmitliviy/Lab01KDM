namespace KDM_Lab01
{
    static class Task06
    {
        public static void SixthTask()
        {
            int a = 210, b = 47, c = 150, d = 50, e = 15, f = 19, g = 9, x, text, graphic, symbbols;


            x = (a - b - c - d + e + f + g) / 2;
            if (x >= 0)
            {
                text = b - e - f + x;
                graphic = c - e - g + x;
                symbbols = d - f - g + x;

                if(text >= 0 && graphic >= 0 && symbbols >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nText procesors: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(text);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nGraphic procesors: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(graphic);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nSymbols procesors: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(symbbols);

                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("This is Impossible!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("This is Impossible!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
