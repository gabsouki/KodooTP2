using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Bureau : Employe

    {
        //Attributs
        protected float salaireFixe;
        protected float salaire;

        //Constructeur
        public Bureau(string fonction, string nom, int matricule, string tel, float salaireFixe)
        {

            this.fonction = fonction;
            this.nom = nom;
            this.matricule = matricule;
            this.tel = tel;
            this.salaireFixe = salaireFixe;
        }

        //Méthode
        public override float Salaire()
        {
            salaireFixe = salaireFixe / 26;
            return salaireFixe;
        }
        public override void Afficher()
        {
            Console.WriteLine("Matricule {0}, {1}, sa fonction est {2}, son numéro de téléphone est le {3}" +
                " et son salaire est de {4}$.",matricule, nom, fonction, tel, salaireFixe);
        }
        public override void Renitialiser()
        {
        }
    }
}
