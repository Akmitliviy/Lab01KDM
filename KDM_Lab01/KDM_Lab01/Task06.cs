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
                Console.WriteLine("Text procesors: {0}\nGraphic procesors: {1}\nSymbols procesors: {2}, x = {3}", text, graphic, symbbols, x);
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
