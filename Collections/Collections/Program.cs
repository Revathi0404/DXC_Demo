//using System.Collections;

//namespace Collections
//{
// internal class Program
//{
// static void Main(string[] args)
//{
// ArrayList list = new ArrayList();
//list.Add(10);
//list.Add(20);
//list.Add("Hello");
//list.Add(2.5f);
//list.Add(true);

//foreach (var i in list)
//{
//Console.WriteLine(i);
// }

//list.Insert(2, "World");

//Console.WriteLine("After Insert");
//foreach (var i in list)
//{
//Console.WriteLine(i);
//  }

//Console.WriteLine(list.Count);
// }
// }
//}

using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(4, "Four");
            list.Add(1, "One");
            list.Add(3, "Three");
            list.Add(2, "Two");
            list.Add(5, "Five");

            //Console.WriteLine(list[3]);
            Console.WriteLine(list.GetKey(2));

            foreach (var item in list.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {list[item]}");
            }

        }
    }
}