using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Operation
    {
        private string idOperation, idCompte, libele, typeOperation;
        private DateTime date;
        private int fond;

        public string IdOperation { get => idOperation; set => idOperation = value; }
        public string IdCompte { get => idCompte; set => idCompte = value; }
        public string Libele { get => libele; set => libele = value; }
        public string TypeOperation { get => typeOperation; set => typeOperation = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Fond { get => fond; set => fond = value; }


        public Operation() { }
        public Operation(string idOperation,string idCompte,string libele,string typeOperation, DateTime date, int fond) { 
            this.idOperation = idOperation;
            this.idCompte = idCompte;
            this.libele = libele;
            this.typeOperation = typeOperation;
            this.date = date;
            this.fond = fond;
        }
    }
}
