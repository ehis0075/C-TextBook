using System;

namespace C_book
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

            //interface: implicitly
            interface IVehicle
            {
                int Wheels { get; }
            }

            class Bike : IVehicle
            {
                private int wheels;
                public int Wheels
                {
                    get 
                    {
                        return wheels;
                    }
                }
            }

             //interface: explicitly
             interface IEnglish
             {
                 int Marks { get; }
             }

             interface IMath
             {
                 int Marks { get; }
             }

             class Student : IEnglish, IMath
             {
                 int english = 10;
                 int maths = 9;

                 int IMath.Marks
                 {
                     get
                     {
                         return english;
                     }
                 }

                 int IEnglish.Marks
                 {
                     get
                     {
                         return maths;
                     }
                 }
             }

             
             //polymorphism
             //method overloading by parameter type
             class Calculator
             {
                 public void Add(int a, int b)
                 {
                     int result = a + b;

                     System.Console.WriteLine("sum of ints = {0}", result);
                 }

                 public void Add(string a, string b)
                 {
                     string result = a + b;

                     System.Console.WriteLine("sum of strings = {0}", result);
                 }
             }

    class Program
    {    
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

            //interface: implicitly
            IVehicle f = new Bike();
            System.Console.WriteLine(f.Wheels);

             //interface: implicitly
             Student st = new Student();
             int english = ((IEnglish)std).Marks;
             int math = ((IMath)std).Marks;

             //polymorphism
             //method overloading by parameter type
             Calculator cal = new Calculator();
             cal.Add(1,2);
             cal.Add("C", "SHARP");

             






            


            






















        }
    }
}
