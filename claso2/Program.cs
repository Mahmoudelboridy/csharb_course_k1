using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace build_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            animal dog = new animal("black","jony",.5);
            dog.print();
        }
      class animal
        {
            string _color;
            string _name;
            double _tall;
            public animal(string color, string name,double tall)
            {
                this._color = color;
                this._tall = tall;
                this._name = name;

            }
            public void print()
            {
                Console.WriteLine($"its name is {_name} and its color is {_color} and its tall is {_tall}");

            }
    }
        

        }
    }



