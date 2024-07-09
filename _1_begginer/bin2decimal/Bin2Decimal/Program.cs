namespace Bin2Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StringBinary;
            int IntDecimal;
            const int InputError = -1;

            Console.Write("Enter up to 8 binary digits: ");
            StringBinary = Console.ReadLine();

            IntDecimal = CalculatorDecimalBinary.Bin2Dec(StringBinary);

            if (IntDecimal != InputError)
            {
                Console.WriteLine($"{IntDecimal} (b10)");
            }

        }
    }
}

/*
story user:
    -  User can enter up to 8 binary digits in one input field
    - User must be notified if anything other than a 0 or 1 was entered
    - User views the results in a single output field containing the decimal (base 10) equivalent of the binary number that was entered             
*/

// bonus features:  User can enter a variable number of binary digits
