using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCsharp.Exercise2
{
    class Compte
    {
        private double solde;

        private int code;

        private Client client;

        public double Solde { get => solde; }
        public int Code { get => code; }
        internal Client Client { get => client; set => client = value; }

        public Compte(Client client)
        {
            this.client = client;
            solde = 0;
            code = new Random().Next(0, 10000);
        }

        public void Crediter(double montant)
        {
            solde = solde + montant;
        }

        public void Crediter(double montant, ref Compte compte)
        {
            solde = solde + montant;
            compte.Debiter(montant);
        }

        public void Debiter(double montant)
        {
            solde = solde - montant;
        }

        public void Debiter(double montant, ref Compte compte)
        {
            solde = solde - montant;
            compte.Crediter(montant);
        }

        public string Resumer()
        {
            return String.Format("Compte N°" + code +" appartenant à " + client.Nom + " " + client.Prenom + "  est créditer de : "+ solde);
        }
    }
}
