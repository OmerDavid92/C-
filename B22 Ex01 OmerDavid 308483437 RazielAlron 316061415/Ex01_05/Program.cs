namespace Ex01_05
{
    public class Program
    {
        public static void    Main()
        {
            string userInput = inputHandler();
            int userInputNumber = int.Parse(userInput);

            int minDigit = getMinDigit(userInput);
            System.Console.WriteLine("The minimum digit is: {0}", minDigit);

            float digitsAverage = getDigitsAverage(userInput);
            System.Console.WriteLine("The digits average is: {0}", digitsAverage);

            int numberOfDigitsDividedBy2 = getNumberOfDigitsDividedBy2(userInput);
            System.Console.WriteLine("The number of digits divided by 2 is: {0}", numberOfDigitsDividedBy2);

            int numberOfDigitsLargerThanUnityDigit = getNumberOfDigitsLargerThanUnityDigit(userInputNumber);
            System.Console.WriteLine("The number of digits larger than unity digit is: {0}", numberOfDigitsLargerThanUnityDigit);
        }

        private static bool   isValidInput(string i_userInput)
        {
            int userInputNumber = 0;
            if (i_userInput.Length != 7)
            {
                return false;
            }

            if (!int.TryParse(i_userInput, out userInputNumber) || userInputNumber <= 0)
            {
                return false;
            }

            return true;
        }

        private static string inputHandler()
        {
            System.Console.WriteLine("Please enter a 7 digits number");
            string userInput = System.Console.ReadLine();
            while (!isValidInput(userInput))
            {
                System.Console.WriteLine("Wrong Input! Please enter a 7 digits number");
                userInput = System.Console.ReadLine();
            }

            return userInput;
        }

        private static int    getMinDigit(string i_UserInput)
        {
            int minDigit = (int)char.GetNumericValue(i_UserInput[0]);
            int currentDigit;
            for (int i = 1; i < i_UserInput.Length; i++)
            {
                currentDigit = (int)char.GetNumericValue(i_UserInput[i]);
                if (minDigit > currentDigit)
                {
                    minDigit = currentDigit;
                }
            }

            return minDigit;
        }

        private static float  getDigitsAverage(string i_UserInput)
        {
            float digitsSum = 0;
            int currentDigit;
            for (int i = 0; i < i_UserInput.Length; i++)
            {
                currentDigit = (int)char.GetNumericValue(i_UserInput[i]);
                digitsSum += currentDigit;
            }

            return digitsSum / i_UserInput.Length;
        }

        private static int    getNumberOfDigitsDividedBy2(string i_UserInput)
        {
            int currentDigit;
            int digitsDividedBy2Counter = 0;
            for (int i = 0; i < i_UserInput.Length; i++)
            {
                currentDigit = (int)char.GetNumericValue(i_UserInput[i]);
                if (currentDigit % 2 == 0)
                {
                    digitsDividedBy2Counter += 1;
                }
            }

            return digitsDividedBy2Counter;
        }

        private static int    getNumberOfDigitsLargerThanUnityDigit(int i_userInputNumber)
        {
            int unityDigit = i_userInputNumber % 10;
            int currentDigit = i_userInputNumber % 10;
            int digitsLargerThanUnityDigitCounter = 0;
            while (i_userInputNumber > 0)
            {
                if (unityDigit < currentDigit)
                {
                    digitsLargerThanUnityDigitCounter += 1;
                }

                i_userInputNumber = i_userInputNumber / 10;
                currentDigit = i_userInputNumber % 10;
            }

            return digitsLargerThanUnityDigitCounter;
        }
    }
}
