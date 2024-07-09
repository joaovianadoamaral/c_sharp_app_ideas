namespace Bin2Decimal
{
    internal class CalculatorDecimalBinary
    {

        public static bool JustZeroOne(string str)
        {
            char[] Caracteres = str.ToCharArray();
            bool DiferentZero, DiferentOne;

            if (str == null)
            {
                Console.WriteLine("String Vazia");
                return false;
            }


            for (int contador = 0; contador < Caracteres.Length; contador++)
            {
                DiferentZero = Caracteres[contador] != '0';
                DiferentOne = Caracteres[contador] != '1';
                if ( DiferentZero && DiferentOne)
                {
                    Console.WriteLine("Algo diferente de '0' ou '1' foi digitado. ");
                    return false;
                }
            }

                return true;
        }

        public static int Bin2Dec(string str)
        {
            char[] Caracteres = str.ToCharArray(); 
            double NumDecimal = 0;
            sbyte count = 0;

            if (! JustZeroOne(str) ) { return (int) -1 ; }

            for (int index = Caracteres.Length - 1; index >= 0; index--)
            {
                if (Caracteres[index] == '1')
                {
                    NumDecimal += Math.Pow(2, count);
                }
                count++;
            }

            return (int)NumDecimal;
        }
    }
}
