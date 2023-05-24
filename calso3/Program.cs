using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace build_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            circle done = new circle(5);
            float area = done.Printf();
            Console.WriteLine(area);
        }
        class circle
        {
            float  _pi=3.14f;
            int _raduis;

           
            public circle(int raduis)
            {
                _raduis = raduis;
            }
            public float Printf()
            {
                return this._raduis * this._pi;
            }
        }


    }
}


