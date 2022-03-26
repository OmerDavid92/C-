namespace Ex01_02
{
    public class Program
    {
        public static void PrintSandClock(int i_Height, int i_NumberOfSpaces = 0)
        {
            string asterisks = new string('*', i_Height);
            string spaces = new string(' ', i_NumberOfSpaces);
            if (i_Height < 2)
            {
                System.Console.WriteLine("{0}*", spaces);
                return;
            }

            System.Console.WriteLine("{0}{1}", spaces, asterisks);
            PrintSandClock(i_Height - 2, i_NumberOfSpaces + 1);
            System.Console.WriteLine("{0}{1}", spaces, asterisks);
        }

        public static void Main()
        {
            PrintSandClock(5);
        }
    }
}