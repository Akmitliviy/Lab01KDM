namespace KDM_Lab01
{
    static class Task03
    {
        static bool isTrue = true;
        public static void ThirdTask()
        {
            string sX, sY;
            string[] D_of_x = { "a", "b" };
            bool q;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nx\ty\tQ(y, y)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-', 23));
            for (int i = 0; i < D_of_x.Length; i++)
            {
                for (int j = 0; j < D_of_x.Length; j++)
                {
                    sX = D_of_x[i];
                    sY = D_of_x[j];

                    q = PredicateQ(sY,sY);
                    ForAll(q);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}\t{1}\t {2}", sX, sY, q);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            Console.WriteLine("Formula is {0}\n", isTrue.ToString());

        }

        static void ForAll(bool predicate)
        {
            if (!(isTrue && predicate))
                isTrue = false;
        }

        static bool PredicateQ(string x, string y)
        {
            if ((x == "a" && y == "a") || (x == "b" && y == "b"))
                return true;
            else
                return false;
        }

    }
}
