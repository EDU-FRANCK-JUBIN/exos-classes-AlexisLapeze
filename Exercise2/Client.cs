using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCsharp.Exercise2
{
    class Client
    {
        public int Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }

        public Client(int cin, string nom, string prenom, string tel)
        {
            Cin = cin;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }

        public Client(int cin, string nom, string prenom)
        {
            Cin = cin;
            Nom = nom;
            Prenom = prenom;
        }

        public string Afficher()
        {
            if (string.IsNullOrEmpty(Tel))
            {
                return string.Format(Cin + " | " + Nom +" "+ Prenom, Cin, Nom, Prenom);
            }
            else
            {
                return string.Format(Cin + " | " + Nom +" "+ Prenom + " " + Tel);
            }
        }
    }
}
