using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilans
{
    public class ViewConsole
    {
        BilController Oblicz;
        public ViewConsole()
        {
            Oblicz = new BilController();
        }
        public void Run()
        {
            while (true)
            {
                string date = DateTime.Now.GetDateTimeFormats('d')[0];
                Console.WriteLine("Aktulanie mamy " + Oblicz.PobieranieSumy() + " pieniążków.\nWprowadź wydatek lub przychód:");
                ConsoleKeyInfo akcja = Console.ReadKey();
                double kwota = Oblicz.WprowadzanieLiczby(akcja);
                double suma = Oblicz.ObliczanieSumy(kwota, Oblicz.PobieranieSumy());
                Console.WriteLine("Co to za wydatek/przychód? (H - halp!)");
                string rodzaj = Oblicz.Rodzaj(Console.ReadKey());
                Console.WriteLine("\n" + kwota + "PLN poszło na " + rodzaj + ".");
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Kot\source\repos\Bilans\" + DateTime.Now.GetDateTimeFormats('y')[0] + ".txt", true))
                {
                    file.WriteLine(date + "  " + kwota + "PLN - " + rodzaj);
                }
                System.IO.File.WriteAllText(@"C:\Users\Kot\source\repos\Bilans\Suma.txt", suma.ToString());
            }
        }
    }
}
