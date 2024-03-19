using System;
using System.Security.Cryptography;//take 2 inputs from user temperature and the type of it C or F

class Program
{
    public static string TempConvert(double tempAmount, string unit)
    {

        if (unit.ToUpper() == "F")
        {
            tempAmount = (tempAmount - 32) / 1.8;//to celsius
            unit = "C";
            return $"{tempAmount}  {unit}";
        }
        else if (unit.ToUpper() == "C")
        { //to fahrenheit
            tempAmount = (tempAmount * 1.8) + 32;
            unit = "F";
            return $"{tempAmount}  {unit}";

        }

        else
        {
            Console.WriteLine("Invalid value");
            return string.Empty;
        }

    }
    public static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Enter temperature and it is unit ,type C for celsius, type F for fahrenheit,to Exit enter quit");

                string info = Console.ReadLine() ?? "";
                if (info.ToLower() == "quit")
                {
                    break;
                }
                string[] arr = info.Split(" ");
                if (arr.Length != 2)
                {
                    Console.WriteLine("Invalid input");
                    continue;


                }

                if (double.TryParse(arr[0], out double tempNum))//Convert it to double
                {
                    string theUnit = arr[1].ToUpper();

                    Console.WriteLine(TempConvert(tempNum, theUnit));
                }

                else
                {
                    Console.WriteLine("--Invalid --Please Enter A numeric temperature value");

                }
            }
        }

        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }








    }
}




