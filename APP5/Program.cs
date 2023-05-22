using System;
namespace app1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first rakm");

            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter tany rakm");

            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"magmo3 is {n1+n2}");
            Console.WriteLine($"tar7 is {n1 - n2}");
            Console.WriteLine($"darb is {n1 * n2}");
            Console.WriteLine($"magmo3 is {n1 / n2}");


        }
    }


}
