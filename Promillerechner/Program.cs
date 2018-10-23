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
            Formeln(Trinkereigenschaften(), Biereigenschaften());
            Console.ReadKey();
        }

        static Trinker Trinkereigenschaften()
        {

            Trinker Mensch = new Trinker();
            Console.WriteLine("Geben Sie folgende Eigenschaften zu Ihrer Person an:");

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
                        Mensch.Körperflüssigkeit = Mensch.Gewicht  * 68 / 100;
                        break;
                    case 'w':
                        Mensch.Geschlecht = "Weiblich";
                        Mensch.Körperflüssigkeit = Mensch.Gewicht * 55 / 100;
                        break;
                    default:
                        Console.WriteLine("ungültiges Geschlecht!");
                        break;
                }



            } while ((Geschlecht != 'm') && (Geschlecht != 'w'));
            Console.WriteLine("Du bist " + Mensch.Geschlecht);
            return Mensch;
        }

        static Getränk Biereigenschaften()
        {

            Console.Clear();
            Getränk Getränk = new Getränk();

            Console.WriteLine("Geben Sie folgende Eigenschaften für das Getränk an:");

            Console.Write("Füllenge in ml : ");
            Getränk.Füllmenge = int.Parse(Console.ReadLine());

            Console.Write("Alkoholgehalt in Vol.-% : ");
            Getränk.Alkoholgehalt = float.Parse(Console.ReadLine());

            Console.Write("Menge an getrunkenen Getränken : ");
            Getränk.Menge = Convert.ToInt16(Console.ReadLine());

            return Getränk;
        }

        static void Formeln(Trinker Mensch, Getränk Getränk)
        {

            double AlkoholinGramm = (Getränk.Füllmenge * (Getränk.Alkoholgehalt / 100) * 0.8);

            double Promille = (Getränk.Menge * AlkoholinGramm) / (Mensch.Gewicht * Mensch.Körperflüssigkeit);

            Console.WriteLine("Sie haben einen Promillewert von : " + Promille.ToString("0.00"));
        }
    }
}
