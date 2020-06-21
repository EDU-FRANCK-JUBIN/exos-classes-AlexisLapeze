using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCsharp.Exercise3
{
    public class Article
    {
        public static int gTauxTva;

        private string reference;
        private string designation;
        private double prixHt;
        private int tauxTVA;

        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public double PrixHt { get => prixHt; set => prixHt = value; }
        public int TauxTVA { get => tauxTVA; set => tauxTVA = value; }


        public Article()
        {

        }

        public Article(string reference, string designation, int prixHt, int tauxTVA)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHt = prixHt;
            this.tauxTVA = tauxTVA;
        }

        public Article(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
        } 

        public Article(Article article)
        {
            this.designation = article.designation;
            this.reference = article.reference;
            this.tauxTVA = article.tauxTVA;
            this.prixHt = article.prixHt;
        }

        public double CalculerPrixTTC()
        {
            return this.prixHt + (this.prixHt * this.tauxTVA / 100);
        }

        /// <summary>
        /// Calcul le prix TTC avec la TVA Globale
        /// </summary>
        /// <returns></returns>
        public double CalculerGlobalPrixTTC()
        {
            return this.prixHt + (this.prixHt * gTauxTva / 100);
        }

        public string AfficherArticle()
        {
            return String.Format("Designation : {0} | Reference : {1} | Prix HT : {2}", this.designation, this.reference, this.prixHt);
        }
    }
}
