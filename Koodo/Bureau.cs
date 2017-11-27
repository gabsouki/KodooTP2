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

        //Constructeur
        public Bureau(string nom, int matricule, string tel, float salaireFixe)
        {

            this.nom = nom;
            this.matricule = matricule;
            this.tel = tel;
            this.salaireFixe = salaireFixe;
        }

        //Méthode
        public override float Salaire()
        {
            return salaireFixe;
        }
        public override void Afficher()
        {
            Console.WriteLine("Matricule {0}, {1}, son numéro de téléphone est le {2}" +
                " et son salaire fixe est de {3}$.", matricule, nom, tel, salaireFixe);
        }
    }
}
