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
        protected string fonction;
        protected string nom;
        protected int matricule;
        protected string tel;


        //Méthodes
        public abstract float Salaire();
        public abstract void Afficher();
        public abstract void Renitialiser();

        //Accesseur
        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Fonction
        {
            get
            {
                return fonction;
            }
        }
    }
}
