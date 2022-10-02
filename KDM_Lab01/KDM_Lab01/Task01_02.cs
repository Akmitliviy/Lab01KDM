namespace KDM_Lab01
{
     static class Task01_02
    {

        static bool p, q, r;

        public static void FirstTask()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n P \t  Q \t  R \t Result");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 32));
            Console.ForegroundColor = ConsoleColor.Cyan;

            bool result;
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        p = Convert.ToBoolean(i);
                        q = Convert.ToBoolean(j);
                        r = Convert.ToBoolean(k);

                        result = p && q && !r && (!p || !q || r);

                        Console.WriteLine(p.ToString() + "\t" + q.ToString() + "\t" + r.ToString() + "\t " + result);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
        public static void SecondTask()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n P \t  Q \t  R \t Result");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 32));
            Console.ForegroundColor = ConsoleColor.Cyan;

            bool result;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        p = Convert.ToBoolean(i);
                        q = Convert.ToBoolean(j);
                        r = Convert.ToBoolean(k);

                        result = ((!p || q) && (!q || p) && !r) || (p && !q) || !p || r;

                        Console.WriteLine(p.ToString() + "\t" + q.ToString() + "\t" + r.ToString() + "\t " + result);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}
