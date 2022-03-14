using System;

namespace ArchitektoraSystemowKomputerowych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide 8 Hexadecimal numbers: ");
            string AH = CheckIfHex(Console.ReadLine());
            string AL = CheckIfHex(Console.ReadLine());
            string BH = CheckIfHex(Console.ReadLine());
            string BL = CheckIfHex(Console.ReadLine());
            string CH = CheckIfHex(Console.ReadLine());
            string CL = CheckIfHex(Console.ReadLine());
            string DH = CheckIfHex(Console.ReadLine());
            string DL = CheckIfHex(Console.ReadLine());
            Console.WriteLine($"{AH} {AL} {BH} {BL} {CH} {CL} {DH} {DL}");
        }
        static public string CheckIfHex(string i)
        {
            long output;
            if (i.Length == 2)
            {
                long.TryParse(i, System.Globalization.NumberStyles.HexNumber, null, out output);
                return i;
            }
            else
            {
                Console.WriteLine("Wrong number, provide correct one: ");
                i = Console.ReadLine();
                return CheckIfHex(i);
            }
        }
    }
}
