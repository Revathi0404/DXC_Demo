namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of length : ");
            decimal Length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the value of breadth : ");
            decimal Breadth = Convert.ToDecimal(Console.ReadLine());

            decimal Perimeter = 2 * (Length + Breadth);

            Console.WriteLine("Perimeter of Rectangle is: " + Perimeter);
            Console.ReadLine();

        }
    }
}