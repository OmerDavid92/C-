namespace Ex01_01
{
    class Program
    {
        private static bool isValidInput(string i_userInput)
        {
            if (i_userInput.Length != 8) 
            { 
                return false;
            }
            for (int i = 0; i < i_userInput.Length; i++)
            {
                if (i_userInput[i] != '0' && i_userInput[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private static string inputHandler()
        {
            System.Console.WriteLine("Please enter a binary number with 8 digits");
            string userInput = System.Console.ReadLine();   
            while (!isValidInput(userInput))
            {
                System.Console.WriteLine("Wrong Input!");
                userInput = System.Console.ReadLine();
            }
            return userInput;
        }

        private static int stringToDecimalConverter(string i_binaryString)
        {
            int decimalNumber = 0;
            for (int i=0; i< i_binaryString.Length; i++) 
            {
                decimalNumber += (int)(i_binaryString[i] - '0') * (int)System.Math.Pow(2, (i_binaryString.Length - 1 - i));
            }
            return decimalNumber;
        }

        private static int binaryZeroDigitsCounter(string i_binaryString)
        {
            int zeroCounter = 0;
            for (int i = 0; i < i_binaryString.Length; i++)
            {
                if (i_binaryString[i] == '0')
                {
                    zeroCounter++;
                }
            }
            return zeroCounter;
        }

        private static void digitsAverageStatistics (string i_binaryString1, string i_binaryString2, string i_binaryString3)
        {
            int zeroTotalCounter = 0;
            int oneTotalCounter = 0;
            zeroTotalCounter += binaryZeroDigitsCounter(i_binaryString1);
            zeroTotalCounter += binaryZeroDigitsCounter(i_binaryString2);
            zeroTotalCounter += binaryZeroDigitsCounter(i_binaryString3);
            oneTotalCounter = 24 - zeroTotalCounter;
            System.Console.WriteLine("Average number of 0: {0}", (zeroTotalCounter / 3));
            System.Console.WriteLine("Average number of 1: {0}", (oneTotalCounter / 3));
        }

        private static int sqrtCheck(int i_decimalNmber)
        {
            double log2 = System.Math.Log(i_decimalNmber, 2);
            if (log2 == System.Math.Floor(log2))
            {
                return 1;
            }
            return 0;
        }

        private static void sqrtStatistics(int i_decimalNmber1, int i_decimalNmber2, int i_decimalNmber3)
        {
            int sqrtCounter = 0;
            sqrtCounter += sqrtCheck(i_decimalNmber1);
            sqrtCounter += sqrtCheck(i_decimalNmber2);
            sqrtCounter += sqrtCheck(i_decimalNmber3);
            System.Console.WriteLine("There are {0} numbers that are powered by 2", sqrtCounter);
        }

        private static int palindromCheck(int i_decimalNmber)
        {
            int originalDecimalNmber = i_decimalNmber;
            int digit = 0;
            int reversedNumber = 0;
            while (i_decimalNmber > 0)
            {
                digit = i_decimalNmber % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                i_decimalNmber = i_decimalNmber / 10;
            }
            if (reversedNumber == originalDecimalNmber)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static void palindromStatistics(int i_decimalNmber1, int i_decimalNmber2, int i_decimalNmber3)
        {
            int palindromCounter = 0;
            palindromCounter += palindromCheck(i_decimalNmber1);
            palindromCounter += palindromCheck(i_decimalNmber2);
            palindromCounter += palindromCheck(i_decimalNmber3);
            System.Console.WriteLine("There are {0} palindroms", palindromCounter);
        }

        private static void sizeStatistics(int i_decimalNmber1, int i_decimalNmber2, int i_decimalNmber3)
        {
            int max = 0; 
            int min = 0;
            max = System.Math.Max(i_decimalNmber1, i_decimalNmber2);
            max = System.Math.Max(max, i_decimalNmber3);
            min = System.Math.Min(i_decimalNmber1, i_decimalNmber2);
            min = System.Math.Min(min, i_decimalNmber3);
            System.Console.WriteLine("The biggest number is: {0}", max);
            System.Console.WriteLine("The smallest number is: {0}", min);
        }

        static void Main()
        {
            string inputNumber1 = inputHandler();
            string inputNumber2 = inputHandler();
            string inputNumber3 = inputHandler();
            int decimalNumber1 = stringToDecimalConverter(inputNumber1);
            int decimalNumber2 = stringToDecimalConverter(inputNumber2);
            int decimalNumber3 = stringToDecimalConverter(inputNumber3);
            digitsAverageStatistics(inputNumber1, inputNumber2, inputNumber3);
            sqrtStatistics(decimalNumber1, decimalNumber2, decimalNumber3);
            palindromStatistics(decimalNumber1, decimalNumber2, decimalNumber3);
            sizeStatistics(decimalNumber1, decimalNumber2, decimalNumber3);
        }

    }
}
