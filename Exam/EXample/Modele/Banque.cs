using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Banque
    {
        private string idBanque, nomBanque,location,contact,idCompleteBanque;

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

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string IdCompleteBanque {
            get { return nomBanque; } 
        }
        public Banque() { }
        public Banque(string idBanque, string nomBanque,string location,string contact)
        {
            this.idBanque = idBanque;
            this.nomBanque = nomBanque;
            this.location = location;
            this.contact = contact;
        }
    }
}
