using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilans
{
    public class BilController
    {
        public double ObliczanieSumy(double dodawana, double sum)
        {
            return sum += dodawana;
        }
        public double PobieranieSumy()
        {
            double suma;
            double.TryParse(System.IO.File.ReadAllText(@"C:\Users\Kot\source\repos\Bilans\Suma.txt"), out suma);
            return suma;
        }
        public double WprowadzanieLiczby(ConsoleKeyInfo akcja)
        {
            double dz = 1;
            double wpis = 0;
            double liczba1 = 0;
            double liczbapoprzecinku = 0;
            bool przecinekaktywny = false;
            if (akcja.Key == ConsoleKey.Subtract || akcja.Key == ConsoleKey.OemMinus)
            {
                akcja = Console.ReadKey();
                for (; ; )
                {
                    if (akcja.KeyChar == ',')
                    {
                        przecinekaktywny = true;
                        akcja = Console.ReadKey();
                        continue;
                    }
                    if (akcja.KeyChar == '0')
                        liczba1 = -0;
                    else if (akcja.KeyChar == '1')
                        liczba1 = -1;
                    else if (akcja.KeyChar == '2')
                        liczba1 = -2;
                    else if (akcja.KeyChar == '3')
                        liczba1 = -3;
                    else if (akcja.KeyChar == '4')
                        liczba1 = -4;
                    else if (akcja.KeyChar == '5')
                        liczba1 = -5;
                    else if (akcja.KeyChar == '6')
                        liczba1 = -6;
                    else if (akcja.KeyChar == '7')
                        liczba1 = -7;
                    else if (akcja.KeyChar == '8')
                        liczba1 = -8;
                    else if (akcja.KeyChar == '9')
                        liczba1 = -9;
                    else
                    {
                        wpis += liczbapoprzecinku;
                        break;
                    }
                    if (przecinekaktywny)
                    {
                        dz *= 10;
                        liczba1 /= dz;
                        liczbapoprzecinku += liczba1;
                    }
                    else
                    {
                        wpis *= 10;
                        wpis += liczba1;
                    }
                    akcja = Console.ReadKey();
                }
            }
            else
            {
                for (; ; )
                {
                    if (akcja.KeyChar == ',')
                    {
                        przecinekaktywny = true;
                        akcja = Console.ReadKey();
                        continue;
                    }
                    if (akcja.KeyChar == '0')
                        liczba1 = 0;
                    else if (akcja.KeyChar == '1')
                        liczba1 = 1;
                    else if (akcja.KeyChar == '2')
                        liczba1 = 2;
                    else if (akcja.KeyChar == '3')
                        liczba1 = 3;
                    else if (akcja.KeyChar == '4')
                        liczba1 = 4;
                    else if (akcja.KeyChar == '5')
                        liczba1 = 5;
                    else if (akcja.KeyChar == '6')
                        liczba1 = 6;
                    else if (akcja.KeyChar == '7')
                        liczba1 = 7;
                    else if (akcja.KeyChar == '8')
                        liczba1 = 8;
                    else if (akcja.KeyChar == '9')
                        liczba1 = 9;
                    
                    else
                    {
                        wpis += liczbapoprzecinku;
                        break;
                    }
                    if (przecinekaktywny)
                    {
                        dz *= 10;
                        liczba1 /= dz;
                        liczbapoprzecinku += liczba1;
                    }
                    else
                    {
                        wpis *= 10;
                        wpis += liczba1;
                    }
                        akcja = Console.ReadKey();
                }
            }
            return wpis;
        }
        public string Rodzaj(ConsoleKeyInfo akcja)
        {
            string rodzaj = "";
            if (akcja.KeyChar == 'h')
            {
                Console.WriteLine("alp!\nO - Opłaty i rachunki\nJ - Jedzenie\nU - Używki\nZ - Zdrowie\nD - Dochody\nI - Inne");
                akcja = Console.ReadKey();
            }
            if (akcja.Key == ConsoleKey.J)
            {
                rodzaj = "Jedzenie";
            }
            else if (akcja.Key == ConsoleKey.O)
            {
                rodzaj = "Opłaty i rachunki";
            }
            else if (akcja.Key == ConsoleKey.U)
            {
                rodzaj = "Używki";
            }
            else if (akcja.Key == ConsoleKey.Z)
            {
                rodzaj = "Zdrowie";
            }
            else if (akcja.Key == ConsoleKey.D)
            {
                rodzaj = "Dochody";
            }
            else if (akcja.Key == ConsoleKey.I)
            {
                Console.WriteLine("\nCo konkretnie?");
                rodzaj = Console.ReadLine();
            }
                return rodzaj;

        }


    }
}
