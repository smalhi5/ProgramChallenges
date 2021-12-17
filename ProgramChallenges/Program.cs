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
            Console.WriteLine("Number that contain odd number of zeroes" + numCount);

            char[] actions = { 'n', 'c', 'n', 'c', 'c', 'c', 'c' , 'n'};
            int[] breakpoints = { 5, 10 };
            int length = 25;
            int currentLine = DetermindTheLineDuringDebugger(actions, breakpoints, length);
            Console.WriteLine("Current Line the debugger " + currentLine);
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

        public static int DetermindTheLineDuringDebugger(char[] actions, int[] breakpoint, int length)
        {
            int currentLine = 1;
            foreach (char action in actions) 
            {
                if (action == 'n' && currentLine < length)
                {
                    currentLine++;
                }
                if (action == 'c' && currentLine < length)
                {
                    int tempNum = breakpoint[0];
                    bool findNumber = false;
                    foreach (int bp in breakpoint) 
                    {
                        if (bp > currentLine && bp <= tempNum)
                        {
                            tempNum = bp;
                            findNumber = true;
                        }
                    }
                    if (findNumber) 
                    {
                        currentLine = tempNum;
                    }
                    if (!findNumber)
                    {
                        currentLine = length;
                    }
                }
            }
            return currentLine;
        }
    }
}
