
namespace NewAbilityScoreCalculator
{
    internal class Program
    {
        static void Main()
        {


            AbilityScoreCalculator calculator = new();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DividedBy = ReadDouble(calculator.DividedBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }
                
        static int ReadInt(int defaultValue, string prompt)
        {
            Console.Write(prompt + $" [{defaultValue}]: ");
            string? line = Console.ReadLine();

            if (int.TryParse(line, out int result))
            {
                Console.WriteLine($"\tusing New value [{result}]");
                return result;
            }
            else
            {
                Console.WriteLine($"\tusing default value [{defaultValue}]");
                return defaultValue;
            }
        }
        static double ReadDouble(double defaultValue, string prompt)
        {
            Console.Write(prompt + $" [{defaultValue}]: ");
            string? line = Console.ReadLine();

            if (double.TryParse(line, out double result))
            {
                Console.WriteLine($"\tusing New value [{result}]");
                return result;
            }
            else
            {
                Console.WriteLine($"\tusing default value [{defaultValue}]");
                return defaultValue;
            }
        }
    }
}
