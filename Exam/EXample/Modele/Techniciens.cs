using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Techniciens : Personne
    {
        private DateTime dateNaiss, dateEmbauche;
        private string diplome;        
        public string Diplome
        {
            get { return diplome;  }
            set { diplome = value; }
        }

        public int Salaire
        {
            get {
                if (diplome == "A2")
                {
                    return 500000;
                }
                else if (diplome == "A1")
                {
                    return 650000;
                }
                else if (diplome == "BAC")
                {
                    return 800000;
                }
                else if (diplome == "Licence")
                {
                    return 800000;
                }
                else if(diplome == "Master")
                {
                    return 900000;
                }
                else
                {
                    return 2200000;
                }
                }
            
            
        }
        
        public DateTime DateNaiss
        {
            get { return dateNaiss; }
            set { dateNaiss = value; }
        }
        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }

        public Techniciens() { }
        public Techniciens(string matricule, string nom, string nationalite, string telephone, string email, string genre, DateTime dateNaiss, DateTime dateEmbauche,string diplome) : 
            base( matricule, nom, nationalite,telephone,email,genre)
        {

            
            this.dateEmbauche = dateEmbauche;
            this.dateNaiss = dateNaiss;
            this.diplome = diplome;
    }
    }
}
