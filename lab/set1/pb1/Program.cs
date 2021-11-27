using System;

namespace pb1
{
    //since I have to use the case statement, I will declare an enum for the variants, it's cleanner this way
    enum Conversion
    {
        Celsius = 1,
        Fahrenheit = 2
    }

    class Program
    {
        static double cel2fah(int value)
        {
            return value * 1.8 + 32;
        }
        static double fah2cel(int value)
        {
            return ((value-32)*5)/9;
            //return value - 32 / 1.8;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Fahrenheit to Celsius convertor");
            //one of the conversion enum variants, would be needed later
            Conversion convert_variant;
            //continuously wait and prompt the user untill a valid input is typed or the program is forcefully interrupted
            while (true)
            {
                Console.WriteLine("what conversion do you want to do?\n1=Celsius, 2=Fahrenheit ");
                string input = Console.ReadLine().ToLower(); //keep it lowercase, not that it would matter to digits
                try
                {
                    convert_variant = (Conversion) Enum.Parse(typeof(Conversion), input, true);
                    Console.WriteLine(convert_variant);
                    break;
                }//try
                catch (Exception e)
                {
                    Console.WriteLine($"Woops, not the excepted input, only 1 and 2 are valid inputs.\nAdditional info: {e.Message}\nTry again");
                }//catch
            } //while
        int n=int.Parse(Console.ReadLine());
        switch(convert_variant)
        {
case Conversion.Celsius:
Console.WriteLine($"result: {cel2fah(n)}");
break;

case Conversion.Fahrenheit:
Console.WriteLine($"result: {fah2cel(n)}");
        break;
        }//switch
        } //main
    } //class
}//namespace