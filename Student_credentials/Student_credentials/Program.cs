namespace Student_credentials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id, m1, m2, m3, t;
            double p;
            string n,a;

            Console.WriteLine(" enter the student Id");
            id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" enter the student Name");
            n = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" enter the student Age");
            a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" enter the student mark 1");
            m1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" enter the student mark 2");
            m2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" enter the student mark 3");
            m3 = Convert.ToInt16(Console.ReadLine());
            t = m1 + m2 + m3;
            p = (t / 3);
            
            if (p >=90 && p<=100){

                Console.WriteLine("Your total Score is" + "  " + t);
                Console.WriteLine("Your total percentage is" + "  " + p);
                Console.WriteLine("Your grade is A");
                Console.WriteLine("Your result is Pass");
            } else if (p >=80 && p <=89)
            {

                Console.WriteLine("Your total Score is" + "  " + t);
                
                Console.WriteLine("Your total percentage is" + "  " + p);
                Console.WriteLine("Your grade is B");
                Console.WriteLine("Your result is Pass");
            }
             else if (p >=60 && p <=79)
            {
                Console.WriteLine("Your total Score is" + "  " + t);
               
                Console.WriteLine("Your total percentage is" + "  " + p);
                Console.WriteLine("Your grade is C");
                Console.WriteLine("Your result is Pass");
            }
             else if(p >=50 && p <=59){
                Console.WriteLine("Your total Score is" + "  " + t);
                
                Console.WriteLine("Your total percentage is" + "  " + p);
                Console.WriteLine("Your grade is D");
                Console.WriteLine("Your result is Pass");
            }
             else if(p < 50)
{
                Console.WriteLine("Your total Score is" + "  " + t);
               
                Console.WriteLine("Your total percentage is" + "  " + p);
                Console.WriteLine("Your grade is E");
                Console.WriteLine("Your result is Fail");
            }



        }
    }
}