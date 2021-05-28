using System;

namespace _9_3
{
    class Program
    {
        public delegate int Number();
        public delegate int MediumCalc(Number[] arrayX);
        public static int Randomizer()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Number[] numArr = new Number[5];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = Randomizer;
                Console.Write(" " + numArr[i]() + " ");
            }
            Console.WriteLine();

            MediumCalc mediumCalc = delegate (Number[] arrayX) 
            {
                int sum = 0; 
                for (int i = 0; i < numArr.Length; i++)
                {
                    int number = numArr[i]();
                    sum += number; 
                }
                int result = sum / arrayX.Length;
                return result;
            }; 
            Console.WriteLine(mediumCalc(numArr)); Console.ReadKey();
        }
    }
}
        
    
