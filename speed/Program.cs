// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the distance");
double distance=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the speed");
double speed=Convert.ToDouble(Console.ReadLine());
double t=distance % speed;
Console.WriteLine("Time taken for the travel"+" "+t);
 
