namespace Array_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            double sum = 0;

            Console.WriteLine("Enter 10 integer values:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Element {i}: ");
                arr[i] = Convert.ToInt16(Console.ReadLine());
                sum += arr[i];
            }

            double average = sum / arr.Length;

            Console.WriteLine($"The average of the elements is {average}");

        }
    }
}