using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace build_method
{
    public class Program
    {
        static void Main(string[] args)
        {

            mnr();
            mntr("5amsa");
            mntrr("hani",17);
            Console.WriteLine(mntkr(5, 6));
            mntkr(5, 6);
            mn(5);
        }
        static void mnr()
        {
            Console.WriteLine("hi");
        }
        static void mntr(string age)
        {
            Console.WriteLine($"my age is {age}");
        }
        static void mntrr(string name,int age)
        {
            Console.WriteLine($"my age is {age} and my name is {name}");
        }
        static int mntkr(int n1,int n2)
        {
           int nm = n1 + n2;
            return  nm;
        }
        static void mn( int num)
        {
            if (num == 5)
            {
                Console.WriteLine("man city 5 dawry in 7 year");
            }
            else if (num>5)
            {
                Console.WriteLine("man city will win by dawryelabtal isa");
            }
            else
            {
                Console.WriteLine("man city will win by kas isa");

            }
            

        }
    }


}
