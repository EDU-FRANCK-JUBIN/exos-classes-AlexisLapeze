using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCsharp.Exercise1
{
    class CompteBancaire
    {
        private string proprietaire;
        private int solde;
        private string devise;

        public static int nbrCompte;

        public string Proprietaire { get => proprietaire; }
        public int Solde { get => solde; }
        public string Devise { get => devise; }

        public CompteBancaire(string proprietaire, int solde, string devise)
        {
            this.proprietaire = proprietaire;
            this.solde = solde;
            this.devise = devise;
        }

        public void Crediter(int montant)
        {
            solde = solde + montant;
        }

        public void Debiter(int montant)
        {
            solde = solde - montant;
        }

        public override string ToString()
        {
            return String.Format("Le compte de : "+ proprietaire + " est créditer de "+ solde +" "+ devise);
        }
    }
}
