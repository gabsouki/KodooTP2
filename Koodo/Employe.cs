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
            Console.WriteLine("Impossible, car cet employé n'est pas un Superviseur");
            Console.ReadKey();
        }

        public virtual void MontantVente(float x)
        {
            Console.WriteLine("Impossible, car cet employé n'est pas un employé commercial");
            Console.ReadKey();
        }

        public virtual void NbrHeures(float x)
        {
            Console.WriteLine("Impossible, car cet employé n'est pas un employé tâche");
            Console.ReadKey();
        }

        //Accesseur
        public string Nom
        {
            get
            {
                return Nom;
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
