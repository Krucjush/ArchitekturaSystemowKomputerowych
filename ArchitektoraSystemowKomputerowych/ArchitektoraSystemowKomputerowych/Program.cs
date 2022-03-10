using System;

namespace ArchitektoraSystemowKomputerowych
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
        }
        static public string Check(string i)
        {
            long output;
            if (i.Length == 2)
            {
                long.TryParse(i, System.Globalization.NumberStyles.HexNumber, null, out output);
                return Convert.ToString(output);
            }
            return null;
        }
    }
}
