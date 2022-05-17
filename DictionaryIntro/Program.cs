using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Berat");
            isimler.Add("Emirhan");
            isimler.Add("Batu");
            isimler.Add("Harun");
            isimler.Add("Berat");
            isimler.Add("Emirhan");
            isimler.Add("Batu");
            isimler.Add("Harun");
            Console.WriteLine(isimler.Count);
            
        }
    }

    class MyDictionary<T> 
    {
        T[] array;
        T[] tempArray;
        public MyDictionary()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item; 
        }
        public int Count
        {
            get { return array.Length; }

        }

    }
}
