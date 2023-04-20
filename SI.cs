namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double p, r, t, Si;

            
            Console.WriteLine("Enter principal amount= ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest= ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time= ");
            t = Convert.ToDouble(Console.ReadLine());

            
            double si = p * r * t / 100;

            
            Console.WriteLine("Simple interest= " + si + "\n");

           
           

        }
    }
}