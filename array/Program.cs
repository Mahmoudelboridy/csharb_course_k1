using System;
namespace app1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] an = { 1, 7, 3, 4 };
            Console.WriteLine(an[1]);
            double[] ann = { 1.3,1.2,1.4,1.7};
            Console.WriteLine(ann[3]);
            string[] annn = { "ahmed", "hassen","ali" };
            Console.WriteLine(annn[1]);
            annn[1] = "van";
            Console.WriteLine(annn[1]);



        }
    }
}

