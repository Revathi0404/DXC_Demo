namespace Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,a;
            Console.WriteLine(" enter the number 1");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" enter the number 2");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" enter the operator");
            Char op = Convert.ToChar(Console.ReadLine());
            


            switch (op)
            {
                case '+':
                    a = num1 + num2;
                    Console.WriteLine("The Result is" + " " + a); break;

                case '-':
                    a = num1 - num2;
                    Console.WriteLine("The Result is" + " " + a); break;

                case '×':
                    a = num1 * num2;
                    Console.WriteLine("The Result is" + " " + a); break;
                case '/':
                    a = num1 / num2;
                    Console.WriteLine("The Result is" + " " + a); break;
                case '%':
                    a = num1 % num2;
                    Console.WriteLine("The Result is" + " " + a); break;

                default:
                    Console.WriteLine("The operation cannot be performed");
                    break;
            }

        }
    }
}