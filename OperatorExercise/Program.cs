
namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            // Addition
            int sum = a + b;
            Console.WriteLine($"{a} + {b} is {sum}");

            // Subtraction
            int difference = a - b;
            Console.WriteLine($"{a} - {b} is {difference}");

            // Multiplication
            int product = a * b;
            Console.WriteLine($"{a} * {b} is {product}");

            // Division
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("Enter radius of a circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with radius {radius} is {area}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
