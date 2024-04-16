using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    internal class Banque
    {
        private string idBanque, nomBanque;

        public string IdBanque
        {
            get { return idBanque; }
            set { idBanque = value; }
        }

        public string NomBanque
        {
            get { return nomBanque; }
            set { nomBanque = value; }
        }
        public Banque() { }
        public Banque(string idBanque, string nomBanque)
        {
            this.idBanque = idBanque;
            this.nomBanque = nomBanque;
        }
    }
}
