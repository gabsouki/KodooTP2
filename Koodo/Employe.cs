using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    abstract class Employe
    {
        //Attributs
        protected string nom;
        protected int matricule;
        protected string tel;


        //Méthodes
        public abstract float Salaire();
        public abstract void Afficher();

        //Accesseur
        public string Nom
        {
            get
            {
                return Nom;
            }
        }

    }
}
