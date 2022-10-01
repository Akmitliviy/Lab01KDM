namespace KDM_Lab01
{
    static class Task03
    {

        public static void ThirdTask()
        {
            string sX, sY;
            string[] D_of_x = { "a", "b" };



        }

        static bool PredicateQ(string x, string y)
        {
            if ((x.ToLower() == "a" && y.ToLower() == "a") || (x.ToLower() == "b" && y.ToLower() == "b"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
