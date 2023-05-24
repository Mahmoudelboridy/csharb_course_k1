using System;

namespace build_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle toyta = new Vehicle();
            toyta.honk();

            Car myCar = new Car();

            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);

        }
        class Vehicle   
        {
            public string brand = "Ford"; 
            public void honk()             
            {
                Console.WriteLine("Tuut, tuut! my vihicle is "+brand);
            }
        }
        class Car : Vehicle 
        {
            public string modelName = "corla";
        }





    }
}

