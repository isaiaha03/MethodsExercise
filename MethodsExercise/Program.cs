namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Beginning of exercise one
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"There once was a kid named {name}, he had a pet {animal} that was {color}, which played in a band called {band}.");
            //End of exercise one

            //Beginning of exercise two
            Console.WriteLine("Addition: ", Add(2, 4, 6, 8));
            Console.WriteLine("Subtraction: ", Subtract(2, 4, 6, 8));
            Console.WriteLine("Multiplication: ", Multiply(2, 4, 6, 8));
            Console.WriteLine("Division: ", Divide(2, 4, 6, 8));
            Console.WriteLine("Modulus: ", Modulus(2, 4, 6, 8));

        }

        public static int Add(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }

        public static int Subtract(params int[] values)
        {
            int num = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                num -= values[i];
            }
            return num;
        }

        public static int Multiply(params int[] values)
        {
            int num = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                num *= values[i];
            }
            return num;
        }

        public static int Divide(params int[] values)
        {
            int num = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                num /= values[i];
            }
            return num;
        }

        public static int Modulus(params int[] values)
        {
            int num = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                num %= values[i];
            }
            return num;
        }
        //End of exercise two

    }
}
