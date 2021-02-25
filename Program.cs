using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.Write("enter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter a number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter operand: ");
            char operand = Convert.ToChar(Console.ReadLine());

            Calculate( numOne, numTwo, operand);
          

            Console.ReadLine();
        

        }


        static void Calculate (int numOne, int numTwo,char operand)
        {
            switch (operand)
            {

                // If user enter +
                case '+':
                    Console.Write(numOne + numTwo);
                    break;

                // If user enter -
                case '-':
                    Console.Write(numOne - numTwo);
                    break;

                // If user enter *
                case '*':
                    Console.Write(numOne * numTwo);
                    break;

                // If user enter /
                case '/':
                    Console.Write(numOne / numTwo);
                    break;

                default:
                    Console.WriteLine("Error! operator is not correct");
                    break;

            }
        }
    }
}

