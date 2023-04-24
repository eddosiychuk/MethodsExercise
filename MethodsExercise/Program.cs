using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Exercise 1-----------------
            //Your Name: Edd
            //Your Favorite Color: Black
            //Your Favorite Animal: 
            //Your Favorite Band:

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. - What is your favorivte color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an cool color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is yopur favorite band??");
            var band = Console.ReadLine();

        }
    }
}