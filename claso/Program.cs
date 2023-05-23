using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace build_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            animal dog = new animal();
            dog.name = "gony";
            dog.tall = .5;
            dog.color = "gray";
            dog.run();
            Console.ReadKey(true);


        }
        class animal
        {
           public string color;
            public double tall;
           public string name;
            public void run()
            {
                Console.WriteLine($"the {name} is running and its tall is {tall} and its color is {color}");
            }
        }
    }
}