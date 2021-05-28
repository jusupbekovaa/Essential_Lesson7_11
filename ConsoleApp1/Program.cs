using System;

namespace ConsoleApp1
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Изменено значение класса";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "Изменено значение структуры";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.Change = "Не измененилось значение класса";
            myStruct.Change = "Не изменилось значение структуры";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);

        }
    }
}
