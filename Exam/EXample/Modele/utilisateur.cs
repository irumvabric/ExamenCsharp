using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class utilisateur
    {

        private string idUtilisateur,nom, prenom, username,password, nomProfile;

        public utilisateur() { }

        public utilisateur(string idUtilisateur, string nom, string prenom, string username, string password, string nomProfile) { 
            this.idUtilisateur = idUtilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.username = username;
            this.password = password;
            this.nomProfile = nomProfile;
        }

        public string IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string NomProfile { get => nomProfile; set => nomProfile = value; }
    }
}
