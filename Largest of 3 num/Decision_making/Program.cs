namespace Decision_making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number one is the largest!");
                }
                else
                {
                    Console.WriteLine("Number three is the largest!");
         }
            }
            else if (num2 > num3)
                Console.WriteLine("Number two is the largest!");
            else
                Console.WriteLine("Number three is the largest!");

        }
    }
}