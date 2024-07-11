namespace Bin2Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StringBinary;

            int IntDecimal;
            int UserAnswer;

            const int Binary2Decimal = 1;
            const int Decimal2Binary = 2;
            const int InputError = -1;

            UserAnswer = Menu();

            if (UserAnswer == Binary2Decimal)
            {

                Console.Write("Enter with binary digits: ");
                StringBinary = Console.ReadLine();

                IntDecimal = CalculatorDecimalBinary.Bin2Dec(StringBinary);

                if (IntDecimal != InputError)
                {
                    Console.WriteLine($"{IntDecimal} (b10)");
                }
            }

            if (UserAnswer == Decimal2Binary)
            {
                // lógica dec2bin

            }

        }

        static int Menu()
        {
            int choose;

            List<string> Options = new List<string>();
            Options = ["\tMENU", "(0) Sair", "(1) BINARY -> DECIMAL ", "(2) DECIMAL -> BINARY"];

            foreach (string Option in Options)
            {
                Console.WriteLine(Option);
            }

            Console.WriteLine();
            Console.Write("CHOOSE >>> ");

            choose = int.Parse(Console.ReadLine());

            return choose;
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
