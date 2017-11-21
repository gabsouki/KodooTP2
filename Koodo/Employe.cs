using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    abstract class Employe
    {
        private string nom;
        private string prenom;
        private string cell;
        private List<string> historique;
        protected abstract int Salaire();
        protected Employe(string nom, string prenom, string cell)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.cell = cell;
            historique = new List<string>();
        }



    }
}
