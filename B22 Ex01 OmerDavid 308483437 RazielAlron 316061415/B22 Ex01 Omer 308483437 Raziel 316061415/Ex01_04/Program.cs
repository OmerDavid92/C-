namespace Ex01_04
{
    class Program
    {
        private static bool isValidInput(string i_userInput)
        {
            bool isNumberInaString = false;
            bool isCharacterInaString = false;
            if (i_userInput.Length != 8)
            {
                return false;
            }
            for (int i=0;i< i_userInput.Length; i++)
            {
                if(i_userInput[i]>='0' && i_userInput[i] <= '9')
                {
                    isNumberInaString = true;
                }
                else
                {
                    isCharacterInaString = true;
                }
            }
            if(isNumberInaString && isCharacterInaString)
            {
                return false;
            }
            return true;
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

        private static bool isPalindrom (string i_userInput)
        {
            if (i_userInput.Length <= 1)
            {
                return true;
            }
            if (i_userInput[0] != i_userInput[i_userInput.Length - 1])
            {
                return false;
            }
            string userInputSubstring = i_userInput.Substring(1, i_userInput.Length - 2);
            return isPalindrom(userInputSubstring);
        }

        private static void isDividedBy3(int i_userInputNumber)
        {
            if (i_userInputNumber % 3 == 0)
            {
                System.Console.WriteLine("It's divided by 3!");
            }
            else
            {
                System.Console.WriteLine("The number isn't divided by 3");
            }
        }

        private static void palindromStatistics(string i_userInput)
        {
            if (isPalindrom(i_userInput))
            {
                System.Console.WriteLine("It's a Palindrom!");
            }
            else
            {
                System.Console.WriteLine("It's not a Palindrom!");
            }
        }

        private static void stringLowerCaseCounter(string i_userInputString)
        {
            int count = 0;
            for (int i=0; i< i_userInputString.Length; i++)
            {
                if (char.IsLower(i_userInputString[i]))
                {
                    count += 1;
                }
            }
            System.Console.WriteLine("There are {0} lowerCase letters in the string", count);
        }

        static void Main()
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
    }
}
