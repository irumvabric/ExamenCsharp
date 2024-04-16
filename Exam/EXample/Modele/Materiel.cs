using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Materiel
    {
        private String idmat, nom, numeroSerie,marque,commentaire,idClient;

        byte[] photo;

        public string Idmat
        {
            get { return idmat; }
            set { idmat = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public string IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public string IdentifMatriComplete
        {
            get
            {
                return idmat + ":" + Nom;
            }
        }

        public Materiel() { }

        public Materiel(string idmat, string nom, string numeroSerie, string marque, string commentaire, string idClient, byte[] photo)
        {
            Idmat = idmat;
            Nom = nom;
            NumeroSerie = numeroSerie;
            Marque = marque;
            Commentaire = commentaire;
            IdClient = idClient;
            Photo = photo;
        }
    }
}
