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
        private int salaire;
        private List<Employe> entres;
        public abstract int Salaire();
        Employe(string nom, string prenom, string cell, int salaire)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.cell = cell;
            this.salaire = salaire;
        }


    }
}
