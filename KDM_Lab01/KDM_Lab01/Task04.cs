namespace KDM_Lab01
{
    static class Task04
    {
        public static void FourthTask()
        {
            int[] Aarr = new int[6] { 1, 3, 4, 5, 7, 9 };
            int[] Barr = new int[7] { 4, 5, 6, 7, 8, 9, 10 };
            int[] Carr = new int[5] { 2, 4, 6, 8, 10 };
            int[] Uarr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            List<int> C = new List<int>();
            List<int> U = new List<int>();

            foreach(int i in Aarr)
                A.Add(i);
            foreach (int i in Barr)
                B.Add(i);
            foreach (int i in Carr)
                C.Add(i);
            foreach (int i in Uarr)
                U.Add(i);

            List<int> first = First(A, B, C, U);
            List<int> second = Second(A, B, C, U);
            List<int> third = Third(A, B, C, U);


            Console.Write("\nFirst: ");
            foreach (int i in first)
                Console.Write(i + ", ");

            Console.Write("\nSecond: ");
            foreach (int i in second)
                Console.Write(i + ", ");

            Console.Write("\nThird: ");
            foreach(int i in third)
                Console.Write(i + ", ");

            Console.WriteLine();
        }

        static List<int> First( List<int> A, List<int> B, List<int> C, List<int> U)
        {
            List<int> notB = new List<int>();
            List<int> first = new List<int>();

            foreach(int i in U)
            { 
                if (!B.Contains(i))
                    notB.Add(i);
            }

            foreach(int i in A)
            {
                if (notB.Contains(i))
                    first.Add(i);
            }

            foreach(int i in C)
            {
                if (first.Contains(i))
                {
                    first.Remove(i);
                    C.Remove(i);
                }
            }

            foreach (int i in C)
                first.Add(i);

            first.Sort();

            return first;
        }

        static List<int> Second(List<int> A, List<int> B, List<int> C, List<int> U)
        {
            List<int> notA = new List<int>();
            List<int> B_Without_notA = new List<int>();
            List<int> second = new List<int>();

            foreach(int i in U)
            {
                if(!A.Contains(i))
                    notA.Add(i);
            }

            foreach(int i in B)
            {
                if (!notA.Contains(i))
                    B_Without_notA.Add(i);
            }

            foreach(int i in C)
            {
                if(!B_Without_notA.Contains(i))
                    B_Without_notA.Add(i);
            }

            foreach(int i in U)
            {
                if(!B_Without_notA.Contains(i))
                    second.Add(i);
            }

            second.Sort();

            return second;
        }
        static List<int> Third(List<int> A, List<int> B, List<int> C, List<int> U)
        {
            List<int> third = A;

            foreach (int i in C)
            {
                if (!A.Contains(i))
                    third.Add(i);
            }

            foreach(int i in B)
            {
                if (third.Contains(i))
                    third.Remove(i);
            }

            third.Sort();

            return third;
        }
    }
}
