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

             // polymorphism
             //static polymorphism
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

                //static polymorphism
             //method overloading by length type
             public void Show(string name)
             {
                 System.Console.WriteLine("Name = {0}", name);
             }

             public void Show(string name, int age)
             {
                 System.Console.WriteLine("Name = {0} - Age = {1}", name, age);
             }

              //operator overloading
              //unary
              class Distance
              {
                  public int meter { get; set; }

                  public static Distance operator ++ (Distance dis)
                  {
                      dis.meter += 1;
                      return dis;
                  }
              }

              //operator overloading
              //overload binary operator
              class Student
              {
                  public int Marks { get; set; }

                  public static Student operator + (Student s1, Student s2)
                  {
                      Student std = new Student();
                      std.Marks = s1.Marks + s2.Marks;

                      return  std;
                  }
              } 

              //Overload Comparison Operator
    class Distance
        {
            public int meter { get; set; }
            public static bool operator < (Distance d1, Distance d2 )
            {
            return (d1.meter < d2.meter);
            }
            public static bool operator > (Distance d1, Distance d2)
            {
            return (d1.meter > d2.meter);
            } 
        }
    }

    //Dynamic polymorphism
                //virtual method
                class Vehicle
                {
                    public virtual void Run()
                    {
                        System.Console.WriteLine("Run vehicle");
                    }
                }

                class Bike: Vehicle
                {
                    public override void Run()
                    {
                        System.Console.WriteLine("Bike run");
                    }
                }

                 //Dynamic polymorphism
                //abstract method
                abstract class Vehicle
                {
                    public abstract void Run();
                }

                class Bike : Vehicle
                {
                    public override void Run()
                    {
                        System.Console.WriteLine("run bike"); 
                    }

                }

                 //Generics

            class GenericClass<T> 
            {
                private T genericField;

                public T GenericMethod(T genericParameter)
                {
                    this.genericField = genericParameter;
                    return this.genericField;
                }

                public T GenericProperty { get; set; }
                
            }


            // constarint where T: new()
            class MyClass
            {
                // default constructor
                public MyClass()
                {

                }
            }

            class GenericClass<T> 
            {

                //todo
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
            //System.Console.WriteLine(v.Wheels);

            //interface: implicitly
            IVehicle f = new Bike();
            //System.Console.WriteLine(f.Wheels);

             //interface: implicitly
             Student st = new Student();
             int english = ((IEnglish)std).Marks;
             int math = ((IMath)std).Marks;

             //polymorphism
             //method overloading by parameter type
             Calculator cal = new Calculator();
             cal.Add(1,2);
             cal.Add("C", "SHARP");


               //static polymorphism
             //method overloading by length type
            Program pc = new Program();   
            pc.Show("Ali");
            pc.Show("Ali", 22);    

            //operator overloading
            Distance dd = new Distance();
            dd.meter = 5;

            distance++;
            //System.Console.WriteLine(dd.meter);


            //operator overloading
            //overload binary operator
            Student s1 = new Student { Marks = 10 };
            Student s2 = new Student { Marks = 20 };
            Student s3 = s1 + s2;
           // Console.WriteLine(s3.Marks); 


               //Overload Comparison Operator
                 Distance d1 = new Distance { meter = 10 };
                Distance d2 = new Distance { meter = 20 };
                if(d1 < d2)
                {
                Console.WriteLine("d1 is less than d2");
                }
                else if(d2 < d1)
                {
                Console.WriteLine("d2 is less than d1");
                }

                //Dynamic polymorphism
                //virtual method
               Vehicle vc1 = new Vehicle();
               vc1.Run();

               //Dynamic polymorphism
                //abstract method
                Vehicle vc = new Vehicle();
                vc.Run();


            //boxing and unboxing
            //boxing
            int age = 22;
            object boxedAge = age;

            //unboxing
            int unboxedAge = (int)boxedAge;


            //Generics
            // here <T> type becomes string i.e a reference type
           GenericClass<string> gen = new GenericClass<string>();
           string strData = gen.GenericMethod("c#");
           gen.GenericProperty = "Cert Exam: ";
           System.Console.WriteLine("{0} {1}", strData, gen.GenericProperty);

            //Generics
            // here <T> type becomes int i.e a value type
           GenericClass<int> gen = new GenericClass<int>();
           int intData = gen.GenericMethod(70);
           genInt.GenericProperty = 290;
           System.Console.WriteLine("{0} {1}", intData, genInt.GenericProperty);




            GenericClass<MyClass> gen = new GenericClass<MyClass>();













            


            






















        }
    }
}
