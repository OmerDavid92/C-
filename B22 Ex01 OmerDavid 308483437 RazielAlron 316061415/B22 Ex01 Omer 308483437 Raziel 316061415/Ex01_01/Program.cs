namespace Ex01_01
{
    public class Program
    {
        public static void Main()
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

        private static bool isValidInput(string i_UserInput)
        {
            if (i_UserInput.Length != 8)
            {
                return false;
            }

            for (int i = 0; i < i_UserInput.Length; i++)
            {
                if (i_UserInput[i] != '0' && i_UserInput[i] != '1')
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

        private static int stringToDecimalConverter(string i_BinaryString)
        {
            int decimalNumber = 0;
            for (int i = 0; i < i_BinaryString.Length; i++)
            {
                decimalNumber += (int)(i_BinaryString[i] - '0') * (int)System.Math.Pow(2, i_BinaryString.Length - 1 - i);
            }

            return decimalNumber;
        }

        private static int binaryZeroDigitsCounter(string i_BinaryString)
        {
            int zeroCounter = 0;
            for (int i = 0; i < i_BinaryString.Length; i++)
            {
                if (i_BinaryString[i] == '0')
                {
                    zeroCounter++;
                }
            }

            return zeroCounter;
        }

        private static void digitsAverageStatistics(string i_BinaryString1, string i_BinaryString2, string i_BinaryString3)
        {
            int zeroTotalCounter = 0;
            int oneTotalCounter = 0;
            zeroTotalCounter += binaryZeroDigitsCounter(i_BinaryString1);
            zeroTotalCounter += binaryZeroDigitsCounter(i_BinaryString2);
            zeroTotalCounter += binaryZeroDigitsCounter(i_BinaryString3);
            oneTotalCounter = 24 - zeroTotalCounter;
            System.Console.WriteLine("Average number of 0: {0}", zeroTotalCounter / 3);
            System.Console.WriteLine("Average number of 1: {0}", oneTotalCounter / 3);
        }

        private static int sqrtCheck(int i_DecimalNmber)
        {
            double log2 = System.Math.Log(i_DecimalNmber, 2);
            if (log2 == System.Math.Floor(log2))
            {
                return 1;
            }

            return 0;
        }

        private static void sqrtStatistics(int i_DecimalNmber1, int i_DecimalNmber2, int i_DecimalNmber3)
        {
            int sqrtCounter = 0;
            sqrtCounter += sqrtCheck(i_DecimalNmber1);
            sqrtCounter += sqrtCheck(i_DecimalNmber2);
            sqrtCounter += sqrtCheck(i_DecimalNmber3);
            System.Console.WriteLine("There are {0} numbers that are powered by 2", sqrtCounter);
        }

        private static int palindromCheck(int i_DecimalNmber)
        {
            int originalDecimalNmber = i_DecimalNmber;
            int digit = 0;
            int reversedNumber = 0;
            while (i_DecimalNmber > 0)
            {
                digit = i_DecimalNmber % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                i_DecimalNmber = i_DecimalNmber / 10;
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

        private static void palindromStatistics(int i_DecimalNmber1, int i_DecimalNmber2, int i_DecimalNmber3)
        {
            int palindromCounter = 0;
            palindromCounter += palindromCheck(i_DecimalNmber1);
            palindromCounter += palindromCheck(i_DecimalNmber2);
            palindromCounter += palindromCheck(i_DecimalNmber3);
            System.Console.WriteLine("There are {0} palindroms", palindromCounter);
        }

        private static void sizeStatistics(int i_DecimalNmber1, int i_DecimalNmber2, int i_DecimalNmber3)
        {
            int max = 0;
            int min = 0;
            max = System.Math.Max(i_DecimalNmber1, i_DecimalNmber2);
            max = System.Math.Max(max, i_DecimalNmber3);
            min = System.Math.Min(i_DecimalNmber1, i_DecimalNmber2);
            min = System.Math.Min(min, i_DecimalNmber3);
            System.Console.WriteLine("The biggest number is: {0}", max);
            System.Console.WriteLine("The smallest number is: {0}", min);
        }
    }
}
