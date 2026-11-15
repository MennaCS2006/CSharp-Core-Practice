using System;

namespace CalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            

            while (playAgain)
            {
                Console.WriteLine("\n ++ CalculatorV1 ++ \n");
                double leftNum = ReadNumber("Enter left hand number: ");
                char op = ReadValidOp("Enter operand: ");
                double rightNum = ReadNumber("Enter right hand number: ");
                TryCalculate(leftNum, rightNum, op, out double result);
                if (result != double.MinValue)
                {
                    Console.WriteLine($"\n{leftNum} {op} {rightNum} = {result}\n");
                }
                else
                {
                    Console.WriteLine("\nError: Cannot divide by zero.\n");
                }
                playAgain = AskToContinue("Do yo wish to exit (y/n)? ");
            }


        }
        static double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (!double.TryParse(Console.ReadLine(), out double Num))
                {
                    Console.WriteLine("\nError! try again\n");
                    continue;
                }
                else
                {
                    return Num;
                }
                
            }
        }
        static char ReadValidOp(string prompt)
        {
            
            string bufferOp = "+-/*";
            while (true)
            { 
                Console.Write(prompt);
                if (!char.TryParse(Console.ReadLine(), out char op) || !bufferOp.Contains(op))
                {
                    Console.WriteLine("\nError! try again\n");
                    continue;

                }
                else
                {
                    return op;
                }
            }
        }
        static bool TryCalculate(double leftNum, double rightNum, char op, out double result)
        {
            result = 0;
            switch (op)
            {
                case '+':
                    result = leftNum + rightNum;
                    return true;
                case '-':
                    result = leftNum - rightNum;
                    return true;
                case '*':
                    result = leftNum * rightNum;
                    return true;
                case '/':
                    if (rightNum == 0) return false;
                    result = leftNum / rightNum;
                    return true;
                default:
                    return false;

            }
        }
        static bool AskToContinue(string prompt)
        {
            Console.Write(prompt);
            if (char.TryParse(Console.ReadLine(), out char exit) && char.ToLower(exit) == 'y')
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
