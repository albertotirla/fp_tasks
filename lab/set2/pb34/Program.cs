using System;

namespace pb34
{
    class Program
    {
        static double rad_to_deg(double radian)
        {
            return radian * 180 / Math.PI;
        }
        static double deg_to_rad(double degree)
        {
            return degree * (Math.PI / 180);
        }
        static void Main(string[] args)
        {
            //let's take it for a spin
            var test_var = 20.0;//degrees
            var expected = test_var; //we expect deg_to_rad(rad_to_deg(x)) to result in x, for any x, including testvar, so we backup testvar before transforming it.
            test_var = deg_to_rad(rad_to_deg(test_var));
            if (test_var == expected)
            {
                Console.WriteLine("yes, the world is right");
            }
            else
            {
                Console.WriteLine("what happened? these are not equal!");
            }
        }
    }
}