using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Lab
{
    class Program
    {
        //Поиск максимума
        public static T Max<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
        //Поиск минимума
        public static T Min<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;
            if (b.CompareTo(min) < 0)
            {
                min = b;
            }
            if (c.CompareTo(min) < 0)
            {
                min = c;
            }
            return min;
        }
        //Поиск суммы
        public static T Sum<T>(T[] arr)
        {
            dynamic sum = default(T);

            foreach (var elem in arr)
            {
                sum += elem;
            }

            return sum;
        }
        //Создание стека
        public class Stack<T>
        {
            private List<T> obj = new List<T>();

            public int Count
            {
                get { return obj.Count; }
            }

            public void Push(T elem)
            {
                obj.Add(elem);
            }

            public T Pop()
            {
                if (obj.Count == 0)
                    throw new InvalidOperationException("Стек пуст");

                T elem = obj[obj.Count - 1];
                obj.RemoveAt(obj.Count - 1);

                return elem;
            }

            public T Peek()
            {
                if (obj.Count == 0)
                    throw new InvalidOperationException("Стек пуст");

                return obj[obj.Count - 1];
            }
        }
        //Создание очереди
        public class Queue<T>
        {
            private List<T> obj = new List<T>();
            public int Count => obj.Count;
            public void Enqueue(T elem)
            {
                obj.Add(elem);
            }
            public T Dequeue()
            {
                if (obj.Count == 0)
                    throw new InvalidOperationException("Очередь пустая");

                T elem = obj[0];
                obj.RemoveAt(0);
                return elem;
            }
            public T Peek()
            {
                if (obj.Count == 0)
                    throw new InvalidOperationException("Очередь пустая");

                return obj[0];
            }
        }
        static void Main(string[] args)
        {
            //1
            int max = Max(1, 2, 3);
            Console.WriteLine($"Max: {max}");
            //2
            int min = Min(1, 2, 3);
            Console.WriteLine($"Min: {min}");
            //3
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
            }
            int sum = Sum(array);
            Console.WriteLine($"Sum: {sum}");
            //4
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine($"Count->{stack.Count}");
            Console.WriteLine($"Peek->{stack.Peek()}");
            stack.Pop();
            Console.WriteLine($"Count->{stack.Count}");
            //5
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            Console.WriteLine($"Peek->{myQueue.Peek()}"); 
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine($"Count->{myQueue.Count}");
        }
    }
}
