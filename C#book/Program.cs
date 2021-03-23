using System;

namespace C_book
{
    class Program
    {

        //multi-level inheritance
            class GrandParent
            {
                public GrandParent()
                {
                    System.Console.WriteLine("Grand parent");
                }
            }

            class Parent : GrandParent
            {
                public Parent()
                {
                    System.Console.WriteLine("Parent");
                }
            }

            class Child : Parent
            {
                public Child()
                {
                    System.Console.WriteLine("Child");
                }
            }


            //abstract classes
            abstract class Vehicle
            {
                protected int wheels;

                public int Wheels
                {
                    get { return wheels; }
                }
            }

            class Bike : Vehicle
            {
                public Bike()
                {
                    base.wheels = 2;
                }
            }
        static void Main(string[] args)
        {
            // private float[] weekTemp = { 47.9F, 34.8F, 12.0F, 26.3F};

            // //use float indexer, to encapsulate weekTemp
            // public float this[int index]
            // {
            //    // get
            //     {
            //         if(index >= 0 && < weekTemp.Length)
            //         {
            //             return weekTemp[index];
            //         }
            //         else
            //         {
            //             return 0;
            //         }
            //     }
            //     Set
            //     {
            //         if(value > 0)
            //         {
            //             weekTemp[index] = value;
            //         }
            //         else
            //         {
            //             //System.Console.WriteLine("pls set value greater than 0");
            //         }
            //     }
            // }

            // //inheritance
            // class Parent
            // {
            //     public string name { get; set; }
            // }

            // class Child : Parent
            // {
            //     private string _name;

            //     public string Name
            //     {
            //         get
            //         {
            //             return (_name + " " + base.name);
            //         }
            //         Set
            //         {
            //             Name = value;
            //         }
            //     }
            // }

        
            // multi-level inheritance
            Child c = new Child();

            // abstract class
            Vehicle v = new Bike();
            System.Console.WriteLine(v.Wheels);


            //interface
            






















        }
    }
}
