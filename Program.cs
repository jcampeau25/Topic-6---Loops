namespace Topic_6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, min, num;
            min = 0;

            Console.WriteLine("Please enter a minimum value");

            while (!Int32.TryParse(Console.ReadLine(), out min))
            {
                Console.WriteLine("Invalid input. Please enter an integer");
            }

            Console.WriteLine("Please enter a maximum value");

            while (!Int32.TryParse(Console.ReadLine(), out max) || max < min)
            {
                Console.WriteLine("Invalid input. Please enter an integer greater than the minimum you previously entered");
            }


            Console.WriteLine("Please enter a number within your range");

            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            {
                Console.WriteLine("Invalid input. Please enter an integer within the range you gave");

            }

            Console.WriteLine($"Great! Your minimum was {min} your maximum number was {max} and the number you chose was {num}");



















        }
    }
}
