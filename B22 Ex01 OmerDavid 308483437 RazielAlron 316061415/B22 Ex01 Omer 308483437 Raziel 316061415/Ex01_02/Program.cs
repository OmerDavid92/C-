namespace Ex01_02
{
    public class Program
    {

        public static void PrintSandClock(int i_height, int i_numberOfSpaces = 0)
        {
            string asterisks = new System.String('*', i_height);
            string spaces = new System.String(' ', i_numberOfSpaces);
            if (i_height < 2)
            {
                System.Console.WriteLine("{0}*", spaces);
                return;
            }
            System.Console.WriteLine("{0}{1}", spaces, asterisks);
            PrintSandClock(i_height - 2, i_numberOfSpaces + 1);
            System.Console.WriteLine("{0}{1}", spaces, asterisks);
        }

        static void Main()
        {
            PrintSandClock(5);
        }
    }
}