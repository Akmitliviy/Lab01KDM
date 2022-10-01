namespace KDM_Lab01
{
    static class Task06
    {
        public static void SixthTask()
        {
            int a = 210, b = 47, c = 150, d = 50, e = 15, f = 19, g = 9, x, text, graphic, symbbols;

            text = b - e - f;
            graphic = c - e - g;
            symbbols = d - f - g;

            if (text >= 0 && graphic >= 0 && symbbols >= 0)
            {
                x = (b - e - f + c - g + d - a) / 2;
                if (x > 0)
                {

                    Console.WriteLine("Text procesors: {0}\nGraphic procesors: {1}\nSymbols procesors: {2}", text, graphic, symbbols);
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
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("This is Impossible!");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }
    }
}
