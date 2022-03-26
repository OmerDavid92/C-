namespace Ex01_04
{
    public class Program
    {
        public static void Main()
        {
            string userInput = inputHandler();
            int userInputNumber = 0;

            palindromStatistics(userInput);
            if (int.TryParse(userInput, out userInputNumber))
            {
                isDividedBy3(userInputNumber);
            }
            else
            {
                stringLowerCaseCounter(userInput);
            }
        }

        private static bool isValidInput(string i_UserInput)
        {
            bool isNumberInaString = false;
            bool isCharacterInaString = false;
            if (i_UserInput.Length == 8)
            {
                for (int i = 0; i < i_UserInput.Length; i++)
                {
                    if (i_UserInput[i] >= '0' && i_UserInput[i] <= '9')
                    {
                        isNumberInaString = true;
                    }
                    else
                    {
                        isCharacterInaString = true;
                    }
                }
            }

            return !(isNumberInaString && isCharacterInaString) && i_UserInput.Length == 8;
        }

        private static string inputHandler()
        {
            System.Console.WriteLine("Please enter a 8 character string");
            string userInput = System.Console.ReadLine();
            while (!isValidInput(userInput))
            {
                System.Console.WriteLine("Wrong Input!");
                userInput = System.Console.ReadLine();
            }

            return userInput;
        }

        private static bool isPalindrom(string i_UserInput)
        {
            if (i_UserInput.Length <= 1)
            {
                return true;
            }

            if (i_UserInput[0] != i_UserInput[i_UserInput.Length - 1])
            {
                return false;
            }

            string userInputSubstring = i_UserInput.Substring(1, i_UserInput.Length - 2);
            return isPalindrom(userInputSubstring);
        }

        private static void isDividedBy3(int i_UserInputNumber)
        {
            if (i_UserInputNumber % 3 == 0)
            {
                System.Console.WriteLine("It's divided by 3!");
            }
            else
            {
                System.Console.WriteLine("The number isn't divided by 3");
            }
        }

        private static void palindromStatistics(string i_UserInput)
        {
            if (isPalindrom(i_UserInput))
            {
                System.Console.WriteLine("It's a Palindrom!");
            }
            else
            {
                System.Console.WriteLine("It's not a Palindrom!");
            }
        }

        private static void stringLowerCaseCounter(string i_UserInputString)
        {
            int count = 0;
            for (int i = 0; i < i_UserInputString.Length; i++)
            {
                if (char.IsLower(i_UserInputString[i]))
                {
                    count += 1;
                }
            }

            System.Console.WriteLine("There are {0} lowerCase letters in the string", count);
        }
    }
}
