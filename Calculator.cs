namespace Calculator_class
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();

            // Demonstrating method overloading
            int sum1 = calculator.Add(1, 2); // Calls Add(int, int)
            int sum2 = calculator.Add(1, 2, 3); // Calls Add(int, int, int)
            double sum3 = calculator.Add(1.5, 2.5); // Calls Add(double, double)

            Console.WriteLine($"Sum of 1 and 2: {sum1}");
            Console.WriteLine($"Sum of 1, 2, and 3: {sum2}");
            Console.WriteLine($"Sum of 1.5 and 2.5: {sum3}");
        }
    }
}
