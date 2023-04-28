using System;
namespace Generic
{

    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Count);

            int poppedItem = stack.Pop();
            Console.WriteLine(poppedItem);

            Console.WriteLine(stack.Count);

            poppedItem = stack.Pop();
            Console.WriteLine(poppedItem);

            Console.WriteLine(stack.Count);

            poppedItem = stack.Pop();
            Console.WriteLine(poppedItem);

            Console.WriteLine(stack.Count);


            try
            {
                poppedItem = stack.Pop();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class MyStack<T>
    {
        private T[] _items;
        private int _count;

        public MyStack()
        {
            _items = new T[0];
            _count = 0;
        }

        public void Push(T item)
        {
            Array.Resize(ref _items, _count + 1);
            _items[_count] = item;
            _count++;
        }

        public T Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty.");

            T item = _items[_count - 1];
            Array.Resize(ref _items, _count - 1);
            _count--;
            return item;
        }

        public int Count
        {
            get { return _count; }
        }
    }
}
