using System;
namespace app1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("man city");
            //Console.Write("man city");
            int age = 32;
            string name = "ali vanter";
            Console.WriteLine($"my name is {name} and my age is {age}");
            Console.WriteLine(name);
            Console.WriteLine("my age is " + age);
            age = 1;
            Console.WriteLine($"my baby age is {age}");
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Contains("vnt"));
            Console.WriteLine(name[5]);
            Console.WriteLine(name.IndexOf("s"));
            Console.WriteLine(name.IndexOf("t"));
            Console.WriteLine(name.Substring(2));
            Console.WriteLine(name.Substring(2,5));
            Console.WriteLine(5%3);
            Console.WriteLine(Math.Abs(-6));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(100));
            Console.WriteLine(Math.Max(2, 3));
            Console.WriteLine(Math.Min(2, 3));
            Console.WriteLine(Math.Round(2.9));
            Console.WriteLine(Math.Floor(2.9));
            Console.WriteLine(Math.Ceiling(10.2));
            Console.WriteLine(Math.Truncate(10.87));

            Console.ReadLine();




        }
    }


}
