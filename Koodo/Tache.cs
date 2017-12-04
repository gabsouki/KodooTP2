using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Tache : Employe
    {
        //Attributs
        protected float tauxHoraire;
        protected float nbrHeures;
        protected float salaire;

        //Constructeur
        public Tache(string fonction,string nom, int matricule, string tel, float tauxHoraire)
        {
            this.fonction = fonction;
            this.nom = nom;
            this.matricule = matricule;
            this.tel = tel;
            this.tauxHoraire = tauxHoraire;
            nbrHeures = 0;
        }

        //Accesseur
        public override void NbrHeures(float x)
        {
            nbrHeures = nbrHeures + x;

        }

        //Méthodes
        public override float Salaire()
        {
            salaire = tauxHoraire * nbrHeures;
            return salaire;
        }
        public override void Afficher()
        {
            Console.WriteLine("Matricule {0}, {1}, sa fonction est {2}, son numéro de téléphone est le {3}" +
    " et son salaire quinzomadaire est de {4}$.", matricule, nom, fonction, tel, salaire);

        }
        public override void Renitialiser()
        {
           nbrHeures = 0;
        }
    }

}
