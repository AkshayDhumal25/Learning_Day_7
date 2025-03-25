// **********************************String vs StringBuilder*****************************************
// Strings are immutable.5
// --Means when we concatenate some text to the preexisting string it'll create the new string and
// assign the value of the whole string to it. Memory allocation for each of the operations
//--StringBuilder is mutable the main reason for using StringBuilder is to save the memory space and uitilize it properly.
// Syntax : StringBuilder sb = new  StringBuilder("Hello");
// It allocate the value for 16 char for the forst time after that 32 and so on. This method provides us the 
// flexibility to make changes in the existing string
// For the StringBuilder the namespace is : using System.Text
//using System;
//using System.Diagnostics;
//using System.Text;
//namespace technicalConcepts
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "";
//            Stopwatch sw1 = Stopwatch.StartNew();
//            for(int i = 1; i < 1000; i++)
//            {
//                str = str + i;
//            }
//            sw1.Stop();

//            StringBuilder stringBuilder = new StringBuilder();
//            Stopwatch sw2 = Stopwatch.StartNew();
//            for(int i = 1; i < 1000; i++)
//            {
//                stringBuilder.Append(i);
//            }
//            sw2.Stop();
//            Console.WriteLine("Time using string : " + sw1.ElapsedMilliseconds);
//            Console.WriteLine("Time using stringBuilder : " + sw2.ElapsedMilliseconds);
//        }
//    }
//}

//*****************************List*********************************
// List = data structure that represents a list of objects that can be accessed by index.
//        Similar to array, but can dynamically increase/decrease in size
//        usng System.Collections.Generic;
//using System;
//namespace lists
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //String[] food = new string[3];

//            //food[0] = "pizza";
//            //food[1] = "humburger";   // The size of array is fixed that's why we are using List 
//            //food[2] = "hotdog";

//            var food = new List<string>();
//            food.Add("pizza");
//            food.Add("hamburger");
//            food.Add("hotdog");


//            foreach(var item in food)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine(food.Count);
//            food.Remove("pizza");
//            Console.WriteLine(food.Count);
//        }
//    }
//}


//************************************** Generics in C# ***************************************
//using System;
//namespace technicalConcepts
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = Console.ReadLine();
//            var b = Console.ReadLine();
//            swap(ref a, ref b);
//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//        static void swap<T>(ref T a, ref T  b)
//        {
//            T temp = a;
//            a = b;
//            b = temp;
//        }
//    }



//}


//************************* Delegates ************************
//using System;
//namespace technicalConcepts
//{
//    public delegate void VoidDelegate();
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            // Print1();
//            VoidDelegate del1 = Print1;
//            myClass.ExecuteDelegate(del1);

//        }
//        private static void Print1()
//        {
//            Console.WriteLine("Method 1");
//        }


//    }
//    class myClass
//    {
//        public static void ExecuteDelegate(VoidDelegate del)
//        {
//            //Console.WriteLine("Method 1");
//            del();
//        }
//    }
//}


//using System;
//delegate void MyDelegate(string message);

//namespace technicalConcepts
//{
//    class Program
//    {
//        static void printMessage(string msg)
//        {
//            Console.WriteLine(msg);
//        }
//        static void Main()
//        {
//            MyDelegate del = printMessage;
//            del("Hello Delegates!");
//        }
//    }
//}



// Find the missing number in the array
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = new int[5] { 1, 2, 3, 5, 6 };
//            int sum = 0;
//            int min = arr[0];
//            int max = arr[0];

//            foreach (int num in arr)
//            {
//                sum += num;
//                if (num < min) min = num;
//                if (num > max) max = num;
//            }
//            int realSum = 0;
//            for(int i = min; i <= max; i++)
//            {
//                realSum += i;
//            }

//            Console.WriteLine(realSum - sum);
//        }
//    }
//}

// Delegates : It's a type safe function pointer
// - A gelegate holds the reference of a method and then calls the method for execution
// - To call a method by using a delegate we have 3 steps:
// 1. Define a delegate [<modifiers>] delegate<Name>([<parameter list>])
// like : public delegate void AddNums(int a, int b)


//namespace DelegatesProject
//{
//    public delegate void AddDelegate(int x, int y);
//    public delegate string SayDelegate(string str);
//    class Program
//    {
//        public void AddNums(int a, int b)
//        {
//            Console.WriteLine(a + b);
//        }

//        public static string SayHello(string Name)
//        {
//            return "Hello" + Name;
//        }
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            AddDelegate ad = new AddDelegate(p.AddNums);
//            //p.AddDelegate(100, 50);
//            ad(100, 50);

//            SayDelegate sd = new SayDelegate(Program.SayHello);
//            string str = sd("Akshay");
//            //string str = Program.SayHello("Raju");
//            Console.WriteLine(str);
//        }
//    }

//}

//namespace exmapleDelegates
//{
//    class Program
//    {
//        public delegate void addDelegate(int x, int y);
//        public void addNums(int a, int b)
//        {
//            Console.WriteLine(a + b);
//        }
//        public static void Main(string[] args)
//        {
//            Program p = new Program();
//            //p.addNums(1, 2);
//            addDelegate ad = new addDelegate(p.addNums);
//            ad(1, 2);
//        }
//    }
//}

// *********** Lamda Expressions ***********
//using System;
//namespace lambdaExpression
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Func<int, int> square = x => x * x;
//            Console.WriteLine(square(5));
//        }
//    }
//}


//*********************** Diamond Problem ****************
//using System;
//interface IA
//{
//    void show();
//}
//interface IB : IA
//{

//}
//interface IC : IA
//{

//}

//class D : IB, IC  // Implements both interfaces
//{
//    public void show()
//    {
//        Console.WriteLine("D::Show()");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        D obj = new D();
//        obj.show(); // Output: D::Show()
//    }
//}