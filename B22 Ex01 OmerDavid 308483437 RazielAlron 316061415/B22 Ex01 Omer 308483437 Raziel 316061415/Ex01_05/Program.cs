namespace Ex01_05
{
    class Program
    {
        private static bool isValidInput(string i_userInput)
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

        private static int getMinDigit(int i_userInputNumber)
        {
            int minDigit = i_userInputNumber % 10;
            while (i_userInputNumber > 0)
            {
                minDigit = System.Math.Min(minDigit, i_userInputNumber % 10);
                i_userInputNumber = i_userInputNumber / 10;
            }
            return minDigit;
        }

        private static float getDigitsAverage(int i_userInputNumber)
        {
            float digitsSum = 0;
            float digitsCounter = 0;
            while (i_userInputNumber > 0)
            {
                digitsSum += i_userInputNumber % 10;
                i_userInputNumber = i_userInputNumber / 10;
                digitsCounter += 1;
            }
            return digitsSum / digitsCounter;
        }

        private static int getNumberOfDigitsDividedBy2(int i_userInputNumber)
        {
            int currentDigit = i_userInputNumber % 10;
            int digitsDividedBy2Counter = 0;
            while (i_userInputNumber > 0)
            {
                if (currentDigit % 2 == 0)
                {
                    digitsDividedBy2Counter += 1;
                }
                i_userInputNumber = i_userInputNumber / 10;
                currentDigit = i_userInputNumber % 10;
            }
            return digitsDividedBy2Counter;
        }

        private static int getNumberOfDigitsLargerThanUnityDigit(int i_userInputNumber)
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



        static void Main()
        {
            string userInput = inputHandler();
            int userInputNumber = int.Parse(userInput);
            
            int minDigit = getMinDigit(userInputNumber);
            System.Console.WriteLine("The minimum digit is: {0}", minDigit);

            float digitsAverage = getDigitsAverage(userInputNumber);
            System.Console.WriteLine("The digits average is: {0}", digitsAverage);

            int numberOfDigitsDividedBy2 = getNumberOfDigitsDividedBy2(userInputNumber);
            System.Console.WriteLine("The number of digits divided by 2 is: {0}", numberOfDigitsDividedBy2);

            int numberOfDigitsLargerThanUnityDigit = getNumberOfDigitsLargerThanUnityDigit(userInputNumber);
            System.Console.WriteLine("The number of digits larger than unity digit is: {0}", numberOfDigitsLargerThanUnityDigit);
        }
    }
  
}
