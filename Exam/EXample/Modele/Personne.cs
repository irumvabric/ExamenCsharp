using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Personne
    {
        string matricule, nom, nationalite, genre, email,telephone;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }
        public string Nationalite
        {
            get { return nationalite; }
            set { nationalite = value; }
        }
        public string Genre
        {
            get { return genre; }
            set {genre = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public Personne(string matricule, string nom, string nationalite, string genre, string email, string telephone)
        {
            this.matricule = matricule; 
            this.nom = nom;
            this.nationalite = nationalite;
            this.genre = genre;
            this.email = email;
            this.telephone = telephone;

        }
        public Personne()
        {

        }
    }
    
}
