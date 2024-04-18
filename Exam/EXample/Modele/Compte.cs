using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Compte
    {
        private string idCompte, typeDeCompte, idBanqueCompte;
        private int solde;

        public string IdCompte { get => idCompte; set => idCompte = value; }
        public string TypeDeCompte { get => typeDeCompte; set => typeDeCompte = value; }
        public string IdBanqueCompte { get => idBanqueCompte; set => idBanqueCompte = value; }
        public int Solde { get => solde; set => solde = value; }

        public Compte() { }

        public Compte(string idCompte, string typeDeCompte, string idBanqueCompte, int solde)
        {
            IdCompte = idCompte;
            TypeDeCompte = typeDeCompte;
            IdBanqueCompte = idBanqueCompte;
            Solde = solde;
        }
    }
}
