using System;
using System.Collections.Generic;
using System.Text;

namespace _10_3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        public int Lenght
        {
            get
            {
                return lenght;
            }
        }
        public MyDictionary(int i)
        {
            key = new TKey[i];
            value = new TValue[i];
            lenght = i;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Попытка обращения за пределы массива значений";
            }
        }
        public void Add(int i, TKey k, TValue v)
        {
            key[i] = k;
            value[i] = v;
        }
    }
}
