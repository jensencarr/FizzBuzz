using System.ComponentModel.Design;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 = fizz
            // 5 = buzz
            // 3 & 5 Fizz Buzz
            // 7 = bazz
            // 3 % 7 = fizz bazz
            // 3 & 5 & 7 = Fizzbuzzbass
            var number = 1;
            while (number != 151)
            {
                if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0 && number % 15 != 0 && number % 21 != 0)
                {
                    Console.WriteLine(number);
                }
                else if (number % 105 == 0)
                {
                    Console.WriteLine("FizzBuzzBazz");
                }
                else if (number % 35 == 0)
                {
                    Console.WriteLine("BuzzBazz");
                }
                else if (number % 21 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 15 == 0)
                {
                    Console.WriteLine("Fizzabuzza");
                }
                else if (number % 7 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                number = number + 1;
            }


         

       
        
           
            
            
        

        }
   
    }
}