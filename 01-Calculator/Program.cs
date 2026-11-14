using System;

namespace CalculatorV1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string bufferOp = "+-/*";
           
            while (playAgain) 
            { 
                Console.WriteLine("\n ++ CalculatorV1 ++ \n");
                Console.Write("Enter left hand number: ");
                if (!double.TryParse(Console.ReadLine(), out double leftNum))
                {
                    Console.Write("Error! try again\n");
                    continue;
                }
                Console.Write("Enter operand: ");
                if (!char.TryParse(Console.ReadLine(), out char op) || !bufferOp.Contains(op))
                {
                    Console.Write("Error! try again\n");
                    continue;

                }
                Console.Write("Enter right hand number: ");
                if (!double.TryParse(Console.ReadLine(), out double rightNum))
                {
                    Console.Write("Error! try again\n");
                    continue;
                }
                switch (op)
                {
                    case '+':
                        Console.WriteLine($"\n{leftNum} + {rightNum} = {leftNum + rightNum}\n");
                        break;
                    case '-':
                        Console.WriteLine($"\n{leftNum} - {rightNum} = {leftNum - rightNum}\n");
                        break;
                    case '*':
                        Console.WriteLine($"\n{leftNum} * {rightNum} = {leftNum * rightNum}\n");
                        break;
                    case '/':
                        if (rightNum != 0)
                            Console.WriteLine($"\n{leftNum} / {rightNum} = {leftNum / rightNum}\n");
                        else
                            Console.WriteLine("Cannot divide by zero.");

                        break;
                    default:
                        Console.WriteLine("Error! try again\n");
                        break;

                }
                Console.Write("Do yo wish to exit (y/n)? ");
                if (char.TryParse(Console.ReadLine(), out char exit) && exit == 'y')
                {
                    playAgain = false;
                }


            }
            

        }
    }
}
