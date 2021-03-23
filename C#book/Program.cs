using System;

namespace C_book
{
    class Program
    {
        static void Main(string[] args)
        {
            private float[] weekTemp = { 47.9F, 34.8F, 12.0F, 26.3F};

            //use float indexer, to encapsulate weekTemp
            public float this[int index]
            {
                get
                {
                    if(index >= 0 && < weekTemp.Length)
                    {
                        return weekTemp[index];
                    }
                    else
                    {
                        return 0;
                    }
                }
                Set
                {
                    if(value > 0)
                    {
                        weekTemp[index] = value;
                    }
                    else
                    {
                        System.Console.WriteLine("pls set value greater than 0");
                    }
                }
            }
        }
    }
}
