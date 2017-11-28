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
        public Commercial(string nom, int matricule, string tel, float salaireFixe) : base(nom, matricule, tel, salaireFixe)
        {

            montantVente = 0;
        }

        //Accesseur
        public float MontantVente
        {
            set
            {
                if (value > 0)
                    montantVente = value;
            }
        }

        //Méthode
        public override float Salaire()
        {
            float salaire = salaireFixe + (montantVente * 0.001f);
            return salaire;
        }


        public override void Renitialiser()
        {
            montantVente = 0;
        }
    }
}

