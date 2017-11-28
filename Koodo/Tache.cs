using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Tache : Employe
    {
        //attributs
        protected float tauxHoraire;
        protected float nbrHeures;

        //Constructeur
        public Tache(string nom, int matricule, string tel, float tauxHoraire)
        {

            this.nom = nom;
            this.matricule = matricule;
            this.tel = tel;
            this.tauxHoraire = tauxHoraire;
            nbrHeures = 0;
        }

        //Accesseur
        public float NbrHeures
        {
            set
            {
                if (value > 0)
                    nbrHeures = value;
            }
        }

        //Méthodes
        public override float Salaire()
        {
            return tauxHoraire * nbrHeures;
        }
        public override void Afficher()
        {
            Console.WriteLine("Matricule {0}, {1}, son numéro de téléphone est le {2}" +
    " et son tauxHoraire est de {3}$.", matricule, nom, tel, tauxHoraire);

        }
        public override void Renitialiser()
        {
           nbrHeures = 0;
        }
    }

}
