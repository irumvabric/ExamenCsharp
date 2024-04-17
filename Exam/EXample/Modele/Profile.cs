using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Profile
    {
        private string id, nomProfile, privilege;
        private int salaire;

        public Profile() { }
        public Profile(string id, string nom, string privilege, int salaire)
        {
            this.id= id;
            this.nomProfile = nom;
            this.privilege = privilege;
            this.salaire = salaire;
        }

        public string Id { get => id; set => id = value; }
        public string Nom { get => nomProfile; set => nomProfile = value; }
        public string Privilege { get => privilege; set => privilege = value; }
        public int Salaire { get => salaire; set => salaire = value; }
    }
}
