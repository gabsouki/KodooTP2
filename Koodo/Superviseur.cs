using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Superviseur : Bureau
    {
        //Attributs
        protected float objectif;

        //Constructeur
        public Superviseur(string fonction, string nom, int matricule, string tel, float salaireFixe) : base(fonction, nom, matricule, tel, salaireFixe)
        {

            objectif = 0;
        }

        //Accesseur
        public float Objectif
        {
            set
            {
                if (value > 0)
                    objectif = value;
            }
        }

        //Méthodes
        public override float Salaire()
        {
            Console.WriteLine("Entrez les ventes du superviseurs {0}",nom);
            float ventes = float.Parse(Console.ReadLine());
            if (objectif <= ventes && objectif > 0)
            {
                salaire = (salaireFixe/26) + (ventes * 0.10f);
                return salaire;
            }
            else
            {
                salaire = (salaireFixe/26);
                return salaire;
            }
        }

        public override void Afficher()
        {
            Console.WriteLine("Matricule {0}, {1}, sa fonction est {2}, son numéro de téléphone est le {3}" +
    " et son salaire cumulé est de {4}$.",matricule, nom, fonction, tel, salaire);

        }

        public override void Renitialiser()
        {
            objectif = 0;
        }

    }
}
