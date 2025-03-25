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


//************************************ Extension Methods ****************************
//using System;
//using Learning_Day_7;
//namespace Demo
//{
//    class Program
//    {
//        static void Main()
//        {
//            string strName = "akshay";
//            //string result = strName.ChangeFirstLetterCase();
//            string result = stringHelper.ChangeFirstLetterCase(strName);
//            Console.WriteLine(result);
//        }
//    }
//}

//**************** Language Integrated Query **********************
//namespace linq
//{
//    class Program
//    {
//        public static void Main()
//        {
//            int[] arr = { 12, 34, 67, 39, 8, 61, 74, 82, 97, 27, 50 };
//            var brr = from i in arr where i > 40 orderby i descending select i;

//            foreach(int x in brr)
//            {
//                Console.Write(x+ " ");
//            }
//        }
//    }
//}

//Logicals
// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the input : ");
//            var n = Convert.ToInt32(Console.ReadLine());
//            string temp = "";
//            while (n > 0)
//            {
//                temp += n % 10;
//                n = n / 10;
//            }
//            Console.WriteLine(temp);

//        }
//    }
//}



//*********************** Nullable Types *********************
//using System;
//namespace nullableTypes
//{
//    class Program
//    {
//        static void Main()
//        {
//            //string Name = null;
//            //int i = null;      // Non-nullable value types
//            //int? i = null;
//            bool? AreYouMajor = false;
//            if(AreYouMajor == true)
//            {
//                Console.WriteLine("User is Major");
//            }else if(AreYouMajor == false)
//            {
//                Console.WriteLine("User is Not Major");
//            }
//            else
//            {
//                Console.WriteLine("User is Did not answer the question");
//            }



//        }
//    }
//}


//using System;
//namespace nullableTypes
//{
//    class Program
//    {
//        static void Main()
//        {
//            int? TicketsOnSale = 10;  //10

//            int AvaialableTickets;

//            if (TicketsOnSale == null)
//            {
//                AvaialableTickets = 0;
//            }
//            else
//            {
//                AvaialableTickets = TicketsOnSale.Value;
//            }

//            Console.WriteLine($"AvaialableTickets = {AvaialableTickets}");
//        }
//    }
//}


//*********************** Dynamic ***********
//using System;
//namespace Types
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            dynamic name = "Akshay";
//            name = 10;
//            Console.WriteLine(name);

//        }
//    }
//}


//2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 20;

//            a = a + b; // 10+30 = 30
//            b = a - b; // 30-20 = 10
//            a = a - b; // 30-10 = 20

//            Console.WriteLine($"A : {a} and B : {b}");
//        }
//    }
//}



// 
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";

            if(str1.Length != str2.Length)
            {
                Console.WriteLine("Invalid");
                
            }
            else
            {
                int[] charCount = new int[256];
                for(int i = 0; i < str1.Length; i++)
                {
                    charCount[str1[i]]++;
                    charCount[str2[i]]++;
                }

                foreach(int i in charCount)
                {
                    if(i != 0)
                    {
                        Console.WriteLine("Not Anagram");
                    }
                }
                Console.WriteLine("Anagram");

            }
        }
    }
}