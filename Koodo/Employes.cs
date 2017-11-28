using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koodo
{
    class Employes

    {
        //Liste de employés
        private List<Employe> employes;
        public Employes()
        {
            employes = new List<Employe>();
        }

       //Embaucher
        public void Embauche(Employe employe)
        {
             employes.Add(employe);
        }

        //Afficher
        public void Afficher()
        {
            foreach (Employe emp in employes)
                emp.Afficher();
        }
        
        //Salaire
        public void Salaire()
        {
            foreach (Employe emp in employes)
                Console.WriteLine("Le salaire de " + emp.Nom + " est de " + emp.Salaire() + "$.");
        }


    }
}

