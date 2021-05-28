using System;

namespace _11_2
{
    class Program
    {
        static void Test<T>() where T : ICar, new()
        {
            var collection = new CarCollection<T>();
            collection.Add("first car", 1999);
            collection.Add("second car", 1999);
            Console.WriteLine("Test collection of type " + typeof(T).Name);
            for (int i = 0; i < collection.Count; i++)
                Console.WriteLine(collection[i]);
        }

        static void Main(string[] args)
        {
            Test<CarA>();
            Test<CarB>();
            Console.ReadLine();
        }
    }
}