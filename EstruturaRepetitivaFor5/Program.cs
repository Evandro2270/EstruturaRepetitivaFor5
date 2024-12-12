using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int n = int.Parse(Console.ReadLine());

                int fat = 1;
                for (int i = 1; i <= n; i++)
                {
                    fat = fat * i;  
                }
                Console.WriteLine(fat);

            }
        }
    }
}  