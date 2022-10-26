namespace KDM_Lab01
{
    static class Task04
    {
        public static void FourthTask()
        {
            int[] Aarr = new int[10] { 1, 0, 1, 1, 1, 0, 1, 0, 1, 0 };
            int[] Barr = new int[10] { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
            int[] Carr = new int[10] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
            int[] Uarr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] first = GetFirst(Aarr, Barr, Carr);
            int[] second = GetSecond(Aarr, Barr, Carr);
            int[] third = GetThird(Aarr, Barr, Carr);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nElements of first set:  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
                if (first[i] == 1)
                    Console.Write(Uarr[i] + ", ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nElements of second set: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
                if (second[i] == 1)
                    Console.Write(Uarr[i] + ", ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nElements of third set:  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 10; i++)
                if (third[i] == 1)
                    Console.Write(Uarr[i] + ", ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
            GetBooleanOfThird(third, Uarr);
        }
        static int[] GetFirst(int[] a, int[] b, int[] c)
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
        static int[] GetSecond(int[] a, int[] b, int[] c)
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
        static int[] GetThird(int[] a, int[] b, int[] c)
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
        static void GetBooleanOfThird(int[] third, int[] universal)
        {
            int l = 0, firstL = 1;
            int[] values = new int[10];

            for (int i = 0; i < third.Length; i++)
                if (third[i] == 1)
                {
                    values[l] = universal[i];
                    l++;
                }

            firstL = Convert.ToInt32(Math.Pow(2, l));
            int?[][] boo = new int?[firstL][];
            boo[0] = new int?[1];

            for (int j = 0; j < l - 1; j++)
            {
                if (j == 0)
                    for (int i = 0; i < l; i++)
                    {

                        boo[i + 1] = new int?[1];
                        boo[i + 1][j] = values[i];
                    }
                else if (j == 1) {
                    for (int k = l, counter = 0; k < SecondBorders(l); k++, counter++)
                    {
                        boo[k + 1] = new int?[2];
                        boo[k + 1][j - 1] = values[counter];
                        if (counter + 1 == l)
                            counter = -1;
                        boo[k + 1][j] = values[counter + 1];
                    }
                }
            }

            boo[firstL - 1] = new int?[l];
            for (int i = 0; i < l; i++)
                boo[firstL - 1][i] = values[i];

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nPower of third set is equal ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(firstL + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            foreach (int?[] i in boo)
            {
                Console.Write("{");
                foreach (int? j in i)
                {
                    Console.Write(" {0} ", j);
                }
                Console.Write("} ");
            }
            Console.WriteLine("\n");

            int SecondBorders(int n)
            {
                if (n == 1) return 1;

                return n + SecondBorders(n - 1);
            }
        }
    }
}
