namespace Ex01_03
{
    class Program
    {
        public static void Main()
        {
            int height = inputHandler();
            Ex01_02.Program.PrintSandClock(height);
        }

        private static int inputHandler()
        {
            int userHeight = 0;
            System.Console.WriteLine("Please enter the height of the sand clock");
            string userInput = System.Console.ReadLine();
            while (!int.TryParse(userInput, out userHeight) || userHeight <= 0)
            {
                System.Console.WriteLine("Wrong Input! Please enter the height of the sand clock");
                userInput = System.Console.ReadLine();
            }

            return userHeight;
        }
    }
}