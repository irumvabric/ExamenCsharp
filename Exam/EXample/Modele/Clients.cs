using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Client : Personne
    {
        string identificationComplete;

        public string IdentificationComplete{
            get
            {
                return Matricule + ":" + Nom;
            }
        }

        
        public Client() { }
        public Client(string matricule, string nom, string nationalite, string telephone, string email, string genre) 
            : base(matricule, nom, nationalite, telephone, email, genre)
        { 
            

        }


    }
}
