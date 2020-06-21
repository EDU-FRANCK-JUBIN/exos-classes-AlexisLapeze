using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCsharp.Exercise1;
using TpCsharp.Exercise2;
using TpCsharp.Exercise3;

namespace TpCsharp
{
    class Program
    {
        public static object Article { get; private set; }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //exercice1();
            //exercice2();
            exercice3();
            Console.ReadLine();
        }

        private static void exercice1()
        {
            CompteBancaire compteCourant = new CompteBancaire("Alexis Lapeze", 0, "euros");
            compteCourant.Crediter(2000);
            compteCourant.Debiter(1000);

            Console.WriteLine(compteCourant.ToString());
        }

        private static void exercice2()
        {

            Client alexisLapeze = new Client(12345, "Lapeze", "Alexis");
            Compte livretA = new Compte(alexisLapeze);
            Compte livretJeune = new Compte(alexisLapeze);

            livretA.Crediter(1000);
            livretJeune.Crediter(1000);

            livretJeune.Crediter(500, ref livretA);

            Console.WriteLine(livretA.Resumer());
            Console.WriteLine(livretJeune.Resumer());
        }

        private static void exercice3()
        {
            Article affiche = new Article();
            affiche.Reference = "12345";
            affiche.Designation = "AfficheA";
            affiche.PrixHt = 10;
            affiche.TauxTVA = 20;

            Console.WriteLine(affiche.AfficherArticle());
            Console.WriteLine("Prix TTC : "+ affiche.CalculerPrixTTC().ToString() + " €");


            Article m90 = new Article("nike", "air max m90", 85, 20);
            Console.WriteLine(m90.AfficherArticle());
            Console.WriteLine("Prix TTC : "+ m90.CalculerPrixTTC() + " €");


            Article caféééééé = new Article("vertuo", "Nespresso vertuo");
            caféééééé.PrixHt = 400;
            caféééééé.TauxTVA = 20;
            Console.WriteLine(caféééééé.AfficherArticle());
            Console.WriteLine("Prix TTC : "+ caféééééé.CalculerPrixTTC() + " €");


            Article JangoFett = new Article("jf", "Original Jango Fett", 1000, 20);
            Article clone = new Article(JangoFett);

            clone.PrixHt = 500;
            Console.WriteLine(clone.AfficherArticle());
            Console.WriteLine("Prix TTC : "+ clone.CalculerPrixTTC() + " €");

            //Avec prix TVA global
            Exercise3.Article.gTauxTva = 50;
            Article biere = new Article();
            biere.Designation = "st Barthelemus";
            biere.Reference = "stBart1234";
            biere.PrixHt = 2;

            Console.WriteLine(biere.AfficherArticle());
            Console.WriteLine("Prix TTC : "+ biere.CalculerGlobalPrixTTC() + " €");

        }
    }
}
