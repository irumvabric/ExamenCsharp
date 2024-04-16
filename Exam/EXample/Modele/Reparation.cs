using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Reparation
    {
        DateTime date;
        string panne,idClient,idMateriel;
        int cout;

        public Reparation() { }
        public Reparation(DateTime date, string panne, string idClient, string idMateriel, int cout)
        {
            Date = date;
            Panne = panne;
            IdClient = idClient;
            IdMateriel = idMateriel;
            Cout = cout;
            Date = date;
            Panne = panne;
            IdClient = idClient;
            IdMateriel = idMateriel;
            Cout = cout;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Panne
        {
            get { return panne; }
            set { panne = value; }
        }

        public string IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }
        public string IdMateriel
        {
            get { return idMateriel; }
            set { idMateriel = value; }
        }
        public int Cout
        {
            get { return cout; }
            set { cout = value; }
        }
    }
}
