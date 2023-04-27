using MyLibrary; 

namespace Calender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;
            Console.WriteLine("Enter the first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator(+, -, *, /): ");
            op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    return;

            }

            Console.WriteLine("Result: "+ result);
        }
    }
}