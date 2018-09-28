using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Trinkereigenschaften();
            Biereigenschaften();
            Console.ReadKey();
        }
        static void Trinkereigenschaften()
        {
            Trinker Mensch = new Trinker();


            Console.Write("Gewicht in kg : ");
            Mensch.Gewicht = Convert.ToInt16(Console.ReadLine());

            Console.Write("Größe in cm : ");
            Mensch.Größe = Convert.ToInt16(Console.ReadLine());

            char Geschlecht;
            do
            {

                Console.Write("Geschlecht m/w: ");
                Geschlecht = Convert.ToChar(Console.ReadLine());
                switch (Geschlecht)
                {
                    case 'm':
                        Mensch.Geschlecht = "Männlich";
                        break;
                    case 'w':
                        Mensch.Geschlecht = "Weiblich";
                        break;
                    default:
                        Console.WriteLine("ungültiges Geschlecht!");
                        break;
                }



            } while ((Geschlecht != 'm') && (Geschlecht != 'w'));
            Console.WriteLine("Du bist " + Mensch.Geschlecht);
        }

        static string Biereigenschaften()
        {
            Console.Clear();

            #region Getränkauswahl
            //string Sorte;
            //do
            //{
            //    Console.WriteLine("Welches Getränk möchten Sie trinken? Bier, Wein, Sekt, eigenes erstellen");
            //    Sorte = Console.ReadLine();

            //    switch (Sorte)
            //    {
            //        case "Bier":
            //            Getränk Bier = new Getränk();
            //            break;

            //        case "Wein":
            //            Getränk Wein = new Getränk();
            //            break;


            //        case "Sekt":
            //            Getränk Sekt = new Getränk();
            //            break;


            //        case "eigenes erstellen":
            //            Console.WriteLine("Geben Sie den Namen ihres Getränks ein!");
            //            var eigenesGetränk = Console.ReadLine();
            //            Getränk eigenGetränk = new Getränk();
            //            break;


            //        default:
            //            Console.WriteLine("ungültige Eingabe!");
            //            break;
            //    }
            //} while ((Sorte != "Bier") && (Sorte != "Wein") && (Sorte != "Sekt") && (Sorte != "eigenes erstellen"));
            #endregion

            Console.WriteLine("Geben Sie folgende Eigenschaften an:");

            Console.Write("Füllenge in ml : ");
            Getränk Füllmenge = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Alkoholgehalt ");
            Getränk.Alkoholgehalt = float.Parse(Console.ReadLine());

            Console.Write("Menge : ");
            int Menge = Convert.ToInt16(Console.ReadLine());
            return
        }

        static void Formeln()
        {
            float reinerAlkohol = Menge * (Füllmenge * (Alkoholgehalt / 100) * 0.8);
            float BAK =
        }
    }
}
