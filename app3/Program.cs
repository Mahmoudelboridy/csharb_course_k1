using System;
namespace app1
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool canivote = true;
            Console.WriteLine(canivote);
            Console.WriteLine("biggest integer:{0}", int.MaxValue);
            Console.WriteLine("smallst integer:{0}", int.MinValue);
            Console.WriteLine("biggest long:{0}", long.MaxValue);
            Console.WriteLine("smallst long:{0}", long.MinValue);
            Console.WriteLine("biggest integer:{0}", decimal.MaxValue);
            Console.WriteLine("biggest Double:{0}", Double.MaxValue);
            Console.WriteLine("biggest float:{0}", float.MaxValue);
            Console.WriteLine("enter 2 rakm");
            string x = Console.ReadLine();
             string y = Console.ReadLine();

            Console.WriteLine(x + y);

        }
    }


}
