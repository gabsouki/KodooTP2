using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Commercial : Bureau
    {
        //Attributs
        protected float montantVente;
        
        //Constructeur
        public Commercial(string fonction, string nom, int matricule, string tel, float salaireFixe) : base(fonction, nom, matricule, tel, salaireFixe)
        {

            montantVente = 0;
        }

        //Accesseur
        public float MontantVente
        {
            set
            {
                if (value > 0)
                    montantVente = montantVente + value;
            }
        }

        //Méthode
        public override float Salaire()
        {
            salaire = (salaireFixe/26) + (montantVente * 0.001f);
            return salaire;
        }

        public override void Afficher()
        {
            Console.WriteLine("Matricule {0}, {1}, sa fonction est {2}, son numéro de téléphone est le {3}" +
    " et son salaire cumulé est de {4}$.",matricule, nom, fonction, tel, salaire);

        }

        public override void Renitialiser()
        {
            montantVente = 0;
        }
    }
}

