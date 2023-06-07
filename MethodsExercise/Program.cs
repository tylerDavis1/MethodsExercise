using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine()!;

            Console.WriteLine("What's your favorite color?");
            string color = Console.ReadLine()!;

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine()!;

            Console.WriteLine("Who's your favorite artist?");
            string artist = Console.ReadLine()!;

            Console.WriteLine("What is your prefered pronoun");
            string pronoun = Console.ReadLine()!;

            Console.WriteLine("What is your age");
            string age = Console.ReadLine()!;

            Console.WriteLine($"There once was a hero named {userName}, {pronoun} rocked hard going into battle bumping {artist}.");
            Console.WriteLine($"Your {animal}, the trusted sidekick was black, and had streaks of {color} on its holster! ");
            Console.WriteLine($"The hero was {age} searching for the fountain of youth, when battle broke out and {animal} was injured!");


            Console.WriteLine("Bet my Brains Faster, Give me a number");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("give me one more.");
            int num2 = int.Parse(Console.ReadLine()!);

            int sum = Sum(num1, num2);
            Console.WriteLine($"Come on thats {sum}, come back with some crazy numbers!");

            Console.WriteLine("ohhhh i see so you're back huh. give me a number");

            int x = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Thats a good one! one more number.");
            int y = int.Parse(Console.ReadLine()!);

            int multi = Multiply(x, y);

            Console.WriteLine($"im a math wizzzz, that's {multi} cant stump me!");


        }

        public static int Sum(int num1, int num2)
        {
            
            int sum = num1 + num2;
            
            
            
            return sum;
        }

        public static int Multiply(int x, int y)
        {
            int multi = x * y;




            return multi;
        }

        public static int Subtraction(int a, int b)
        {
            
            int sub = a - b;
            
            
            
            
            return a - b;
        }

        public static int Divition(int c, int d)
        {
            
            int div = c / d;
            
            
            return c / d;
        }
    
    }
}
