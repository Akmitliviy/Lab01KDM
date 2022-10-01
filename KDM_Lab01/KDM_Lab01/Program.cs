namespace KDM_Lab01
{
    class Program
    {
        public static void Main()
        {
            while(true)
            {
                Program program = new Program();

                switch (program.Hello())
                {
                    case 1:
                        Task01_02.FirstTask();
                        break;
                    case 2: 
                        Task01_02.SecondTask();
                        break;
                    case 3:
                        Task03.ThirdTask();
                        break;
                    case 4:
                        Task04.FourthTask();
                        break;
                    case 6:
                        Task06.SixthTask();
                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nSorry, but we don't have this task. Please, try again.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Press \"S\" to stop process, or anything else to continue: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string goNext = Console.ReadLine();

                if (goNext.ToLower() == "s" || goNext.ToLower() == "stop")
                    break;
            }
        }
        int Hello()
        {
            int taskNumber;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please, Enter the number of task, you want to check: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                taskNumber = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch (FormatException)
            {
                return -1;
            }

            return taskNumber;
        }
    }
}