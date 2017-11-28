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
        public Superviseur(string nom, int matricule, string tel, float salaireFixe) : base(nom, matricule, tel, salaireFixe)
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
            Console.WriteLine("Entrez les ventes du superviseurs");
            float ventes = float.Parse(Console.ReadLine());
            if (objectif < ventes)
            {
                return salaireFixe + (ventes * 0.10f);
            }
            else
            {
                return salaireFixe;
            }

        }
        public override void Renitialiser()
        {
            objectif = 0;
        }

    }
}
