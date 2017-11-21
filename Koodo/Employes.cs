using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Employes
    {
        private List<Employe> employes;
        public Employes()
        {
            employes = new List<Employe>();
        }
       
        public void Embauche(string fonction, string nom, string prenom, string cell, int salaire)
        {
            employes.Add(new X(nom, prenom, cell, salaire));
        }


        }
    }
}
