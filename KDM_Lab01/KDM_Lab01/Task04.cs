namespace KDM_Lab01
{
    static class Task04
    {
        public static void FourthTask()
        {
            int[] Aarr = new int[10] { 1, 0, 1, 1, 1, 0, 1, 0, 1, 0 };
            int[] Barr = new int[10] { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
            int[] Carr = new int[10] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
            int[] Uarr = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nElements of first set:  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                if (GetFirst(Aarr, Barr, Carr, Uarr)[i] == 1)
                {
                    Console.Write(++i + ", ");
                    --i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nElements of second set: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                if (GetSecond(Aarr, Barr, Carr, Uarr)[i] == 1)
                {
                    Console.Write(++i + ", ");
                    --i;
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nElements of third set:  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
            {
                if (GetThird(Aarr, Barr, Carr, Uarr)[i] == 1)
                {
                    Console.Write(++i + ", ");
                    --i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
        }
        static int[] GetFirst(int[] a, int[] b, int[] c, int[] u)
        {
            int[] notB = new int[10];
            int[] aAndNotB = new int[10];
            int[] first = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if(b[i] == 0)
                    notB[i] = 1;
                else
                    notB[i] = 0;
            }

            for(int i = 0; i < 10; i++)
            {
                if(a[i] == 1 && notB[i] == 1)
                    aAndNotB[i] = 1;
                else
                    aAndNotB[i] = 0;
            }

            for (int i = 0; i < 10; i++)
            {
                if ((aAndNotB[i] == 1 && c[i] == 1) || (aAndNotB[i] == 0 && c[i] == 0))
                    first[i] = 0;
                else
                    first[i] = 1;
            }

            return first;
        }
        static int[] GetSecond(int[] a, int[] b, int[] c, int[] u)
        {
            int[] notA = new int[10];
            int[] b_Without_NotA = new int[10];
            int[] leftOrRight = new int[10];
            int[] second = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (a[i] == 1)
                    notA[i] = 0;
                else
                    notA[i] = 1;
            }

            for (int i = 0; i < 10; i++)
            {
                if (b[i] == 1 && notA[i] == 0)
                    b_Without_NotA[i] = 1;
                else
                    b_Without_NotA[i] = 0;
            }

            for(int i = 0; i < 10; i++)
            {
                if (b_Without_NotA[i] == 1 || c[i] == 1)
                    leftOrRight[i] = 1;
                else
                    leftOrRight[i] = 0;
            }

            for (int i = 0; i < 10; i++)
            {
                if (leftOrRight[i] == 1)
                    second[i] = 0;
                else
                    second[i] = 1;
            }

            return second;
        }
        static int[] GetThird(int[] a, int[] b, int[] c, int[] u)
        {
            int[] a_And_C = new int[10];
            int[] third = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (a[i] == 1 || c[i] == 1)
                    a_And_C[i] = 1;
                else
                    a_And_C[i] = 0;
            }

            for (int i = 0; i < 10; i++)
            {
                if (a_And_C[i] == 1 && b[i] == 0)
                    third[i] = 1;
                else
                    third[i] = 0;
            }

            return third;
        }

    }
}
