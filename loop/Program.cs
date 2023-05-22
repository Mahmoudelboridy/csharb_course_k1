using System;
namespace app1
{
    public class Program
    {
        static void Main(string[] args)
        {
        

            for(int i=0; i<=7;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("fasla");

            int[] am = { 1, 2, 5, 77, 9, 61, 16, 44, 42, 47 };
            for (int f = 0; f< am.Length; f++)
            {
                Console.WriteLine(am[f]);
            }

        }
    }


}
