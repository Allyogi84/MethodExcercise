using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------Excercise 1

            //Name: Anthony
            //Favorite Color: Blue
            //Favorite Animal: Shark
            //Favorite Band: Jimmy Buffet


            Console.WriteLine("Hello, What is your first name");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi,{userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color}, is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Awesomesauce!, What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"this is all great, Do you have any hobbies?");
            var hobbies = Console.ReadLine();

            Console.WriteLine($"Thanks! I wish I could do that but sadly I am a computer");
            var cool = Console.ReadLine();




        }
    }
}
