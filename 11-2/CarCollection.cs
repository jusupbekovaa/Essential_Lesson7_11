using System;
using System.Collections.Generic;
using System.Text;

namespace _11_2
{
    interface ICar
    {
        string Name { get; set; }
        int Year { get; set; }
    }

    class CarCollection<T> where T : ICar, new()
    {
        List<T> Cars = new List<T>();

        public void Add(string Name, int Year)
        {
            Cars.Add(new T() { Name = Name, Year = Year });
        }

        public T this[int Index]
        {
            get { return Cars[Index]; }
            set { Cars[Index] = value; }
        }

        public int Count
        {
            get { return Cars.Count; }
        }
    }

    class CarA : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"A: {Name} {Year}";
        }
    }

    class CarB : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"B: {Name} {Year}";
        }
    }


}
