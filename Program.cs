// String vs StringBuilder
// Strings are immutable.5
// --Means when we concatenate some text to the preexisting string it'll create the new string and
// assign the value of the whole string to it. Memory allocation for each of the operations
//--StringBuilder is mutable the main reason for using StringBuilder is to save the memory space and uitilize it properly.
// Syntax : StringBuilder sb = new  StringBuilder("Hello");
// It allocate the value for 16 char for the forst time after that 32 and so on. This method provides us the 
// flexibility to make changes in the existing string
// For the StringBuilder the namespace is : using System.Text
using System;
using System.Diagnostics;
using System.Text;
namespace technicalConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "";
            Stopwatch sw1 = Stopwatch.StartNew();
            for(int i = 1; i < 1000; i++)
            {
                str = str + i;
            }
            sw1.Stop();

            StringBuilder stringBuilder = new StringBuilder();
            Stopwatch sw2 = Stopwatch.StartNew();
            for(int i = 1; i < 1000; i++)
            {
                stringBuilder.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time using string : " + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time using stringBuilder : " + sw2.ElapsedMilliseconds);
        }
    }
}
