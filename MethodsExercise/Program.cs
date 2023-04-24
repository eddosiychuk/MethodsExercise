using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

        
        
            //-----------------------Exercise 1-----------------
            //Your Name
            //Your Favorite Color
            //Your Favorite Animal
            //Your Favorite Band

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. - What is your favorivte color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an cool color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is yopur favorite band??");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("------------------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");



            //-----------------------Exercise 1-----------------
        }
    }
}