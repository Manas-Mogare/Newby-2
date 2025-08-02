namespace Calculator_form_scratch_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            // Read and parse the first number
            Console.WriteLine("Please enter the first number:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input for the first number.");
                return;
            }

            // Read and parse the second number
            Console.WriteLine("Please enter the second number:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input for the second number.");
                return;
            }

            // Read the operation
            Console.WriteLine("Please enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(operation) || operation.Length != 1)
            {
                Console.WriteLine("Invalid operation. Please enter a single character (+, -, *, /).");
                return;
            }

            char operationChar = operation[0];
            double result;

            switch (operationChar)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
                    return;
            }

            Console.WriteLine($"Result: {num1} {operationChar} {num2} = {result}");
        }
    }
}
