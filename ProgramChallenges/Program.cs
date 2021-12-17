using System;

namespace ProgramChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = { 30, 4, 700, 10070, 3000 };
            int numCount = FindNumberWithOddNumberOfZero(numbers);
            Console.WriteLine(numCount);
        }

        public static int FindNumberWithOddNumberOfZero(int[] numbers) 
        {
            int numCount = 0;
            foreach (int num in numbers)
            {
                string tempNum = num.ToString();
                int zeroCount = 0;
                for (int i = 0; i < tempNum.Length; i++)
                {
                    if (tempNum[i] == '0')
                    {
                        zeroCount++;
                    }
                }
                if (zeroCount % 2 == 1) 
                {
                    numCount++;
                }
            }
            return numCount;
        }
    }
}
