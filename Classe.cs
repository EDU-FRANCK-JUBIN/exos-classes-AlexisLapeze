using System;

namespace test
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Compte C1 = new Compte(new Client("1234", "lapeze", "Alexis", "0615151515"));
            C1.afficher();

            Console.WriteLine("\non crédite 100 €\n");
            C1.crediter(100);
            C1.afficher();

            Console.Out.Write("\non debite 37 \n");
            C1.debiter(37);
            C1.afficher();

            Compte C2 = new Compte(new Client("4321", "desrosiers", "loic", "0612121212"));
            C2.afficher();
            Console.Out.WriteLine("\non credite le compte 2 à partir du compte 1\n");
            C2.crediter(50, C1);
            C2.afficher();

            Console.Out.WriteLine("\non débite le compte 1 et on crédite le compte 2\n");
            C1.debiter(70, C2);

            C1.afficher();
            C2.afficher();

            Compte.Nombre_Comptes();

            Console.WriteLine("\nCréation des Articles : \n");
            Article A1 = new Article();
            Article A2 = new Article("1234", "ceci est mon deuxieme article");
            Article A3 = new Article(A2);
            A3.Reference = "4321";
            A3.Designation = "ceci est mon troisieme article";
            Article A4 = new Article("5678", "ceci est mon quatrieme article", 150, 20);
            Console.WriteLine(A1.Reference + " " + A1.Designation + " " + A1.PrixHT + " " + A1.TauxTVA);
            Console.WriteLine(A2.Reference + " " + A2.Designation + " " + A2.PrixHT + " " + A2.TauxTVA);
            Console.WriteLine(A3.Reference + " " + A3.Designation + " " + A3.PrixHT + " " + A3.TauxTVA);
            Console.WriteLine(A4.Reference + " " + A4.Designation + " " + A4.PrixHT + " " + A4.TauxTVA);
            A4.CalculerPrixTTC();
            Article2 A5 = new Article2("9876", "ceci est mon cinquieme article", 200);
            A5.CalculerPrixTTC();

            Boucles.Entre();

        }
    }

    public class CompteBancaire
    {
        private Client titulaire;
        private float solde;
        private string devise;
        private Client client;
        private Client p_proprio;

        public Client Titulaire
        {
            get { return titulaire; }
            set { titulaire = value; }
        }

        public float Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public string Devise
        {
            get { return devise; }
            set { devise = value; }
        }

        public CompteBancaire(Client p_proprio, float p_solde, string p_devise)
        {
            this.titulaire = p_proprio;
            this.solde = p_solde;
            this.devise = p_devise;
        }

        public CompteBancaire(Client p_proprio)
        {
            this.p_proprio = p_proprio;
        }

        public void decrire(float montant)
        {
            Console.WriteLine("Bonjour " + this.titulaire + " vous avez " + this.solde + this.devise + ".");
        }
    }

    public class Compte
    {
        private int numero;
        private float solde;
        private Client proprietaire;
        private static int nombre_comptes = 0;

        public int Numero
        {
            get { return numero; }
            //set { this.numeroCompte = value; }
        }

        public Compte(Client proprietaire)
        {
            nombre_comptes++;
            numero = nombre_comptes;
            this.proprietaire = proprietaire;
        }

        public float Solde
        {
            get { return solde; }
        }

        public Client Titulaire
        {
            get { return this.Titulaire.Nom; }
        }

        public void crediter(float montant, Compte compte)
        {
            this.solde += montant;
            compte.solde -= montant;
        }

        public void crediter(float montant)
        {
            this.solde += montant;
        }

        public void debiter(float montant)
        {
            this.solde -= montant;
        }

        public void debiter(float montant, Compte compte)
        {
            this.solde -= montant;
            compte.solde += montant;
        }
        public void afficher()
        {
            Console.Out.WriteLine("Numéro de Compte: " + numero + " Solde de compte: " + solde + " Propriétaire du compte : ");
            proprietaire.afficher();

        }
        public static void Nombre_Comptes()
        {
            Console.Out.WriteLine("Nombre de comptes : " + nombre_comptes);
        }
    }

    public class Client
    {
        private string cni;
        private String nom;
        private String prenom;
        private String tel;
        private Compte[] comptes;

        public string Cni
        {
            get { return cni; }
            set { cni = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Compte
        {
            get { return tel; }
            set { tel = value; }
        }

        public Client(string p_cni, string p_nom, string p_prenom, string p_tel)
        {
            this.cni = p_cni;
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.tel = p_tel;
        }

        public Client(string p_cni, string p_nom, string p_prenom)
        {
            this.cni = p_cni;
            this.nom = p_nom;
            this.prenom = p_prenom;
        }

        public void afficher()
        {
            Console.WriteLine("CNI : " + this.Cni);
            Console.WriteLine("Nom : " + this.Nom);
            Console.WriteLine("Prenom : " + this.Prenom);
            Console.WriteLine("Tel : " + this.Tel);
        }

        public static implicit operator Client(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class Article // v1
    {
        private string reference;
        private string designation;
        private double prixHt;
        private int tauxTVA;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public double PrixHT
        {
            get { return prixHt; }
            set { prixHt = value; }
        }

        public int TauxTVA
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }

        public Article()
        {
        }

        public Article(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
        }


        public Article(string reference, string designation, int prixHt, int tauxTVA)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHt = prixHt;
            this.tauxTVA = tauxTVA;

        }

        public Article(Article article)
        {
            reference = article.reference;
            designation = article.designation;
            prixHt = article.prixHt;
            tauxTVA = article.tauxTVA;

        }
        public void CalculerPrixTTC()
        {
            double prixTTC = (prixHt * (TauxTVA / 100)) + prixHt;
            Console.WriteLine("prixTTC = " + prixTTC);
        }
    }

    public class Article2 // v2
    {
        private string reference;
        private string designation;
        private double prixHt;
        protected int tauxTVA = 20;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public double PrixHT
        {
            get { return prixHt; }
            set { prixHt = value; }
        }

        public int TauxTVA
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }

        public Article2()
        {
        }

        public Article2(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
        }

        public Article2(string reference, string designation, double prixHt)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHt = prixHt;

        }

        public Article2(Article2 article)
        {
            reference = article.reference;
            designation = article.designation;
            prixHt = article.prixHt;

        }
        public void CalculerPrixTTC()
        {
            Console.WriteLine("prixTTC = " + prixHt * (1 + this.TauxTVA / 100));
        }
    }
}