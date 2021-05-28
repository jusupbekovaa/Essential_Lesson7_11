using System;
using System.Linq;

namespace _10_3
{
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество слов словаря:");
            int n = int.Parse(Console.ReadLine());
            var dictionary = new MyDictionary<string, string>(n);
            for(int i = 0; i < n; i++)
            {
                dictionary.Add(i,RandomString(4) , RandomString(5));
                Console.Write($"Элемент #{i} это {dictionary[i]}\n");
            }
            Console.WriteLine("Введите номер слова: ");
            int k = int.Parse(Console.ReadLine());
            if (k<= dictionary.Lenght)
            {
                Console.WriteLine($"Элемент #{k} - {dictionary[k]}");
            }
        }
    }
}
