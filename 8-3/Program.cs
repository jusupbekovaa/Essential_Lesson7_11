using System;

namespace _8_3
{
    class Program
    {
        public enum Position
        {
            Head = 50,
            IT = 40,
            Manager = 45

        }
        class Accauntant
        {
            public bool AskForBonus(Position worker, int hours)
            {
                if(worker.GetHashCode() < hours)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            bool result = accauntant.AskForBonus(Position.Head, 60);
            if(result == true)
            {
                Console.WriteLine("Премия начислена");
            }
            else
            {
                Console.WriteLine("Премия не начислена");
            }
        }
    }
}
