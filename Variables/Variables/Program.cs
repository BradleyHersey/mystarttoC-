using System;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
 //can also use var 
            byte number =2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Brad";
            bool isWorking = false;
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MaxValue, float.MaxValue);


        }
    }
}
