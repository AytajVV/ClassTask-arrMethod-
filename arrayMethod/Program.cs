using System;

namespace arrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Names("lorem", "ipsum", "hello", "515"));
            //Console.WriteLine(Names(new string[]{ "hello", "bye"}));  
        }
        static int Names(params string[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                count++;
            }
            return count;
        }
    }
}
