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
        public virtual void Objectif(float x)
        {
            Console.WriteLine("Impossible, car cet employé n'est pas un Superviseur.");
        }

        public virtual void MontantVente(float x)
        {
            Console.WriteLine("Impossible, car cet employé n'est pas un employé Commercial.");
        }

        public virtual void NbrHeures(float x)
        {
            Console.WriteLine("Impossible, car cet employé n'est pas un employé Tâche.");
        }

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
                return Fonction;
            }
        }
    }
}
