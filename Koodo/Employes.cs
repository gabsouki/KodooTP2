﻿using System;
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
            foreach (Employe employe in employes)
                employe.Afficher();
        }
        
        //Salaire
        public void Salaire()
        {
            foreach (Employe emp in employes)
                Console.WriteLine("Le salaire quinzomadaire de " + emp.Nom + " est de " + emp.Salaire() + "$.");
        }

        public void Renitialiser()
        {
            foreach (Employe emp in employes)
                emp.Renitialiser();
        }
        public void Objectif(string nom, float x)
        {
            
            foreach (Superviseur emp in employes)
                if (emp.Nom.Equals(nom))
                {
                    emp.Objectif = x;
                    break;
                }
                else
                {
                Console.WriteLine("L'employé n'existe pas ou n'est pas un superviseur. Aucun objectif n'a été enregistré.");
                Console.ReadKey();
                }
        }
        public void Ventes(string nom, float x)
        {
            foreach (Commercial emp in employes)
                if(emp.Nom.Equals(nom))
                emp.MontantVente = x;
        }
        public void Heures(string nom, float x)
        {
             foreach (Tache emp in employes)
                if (emp.Nom.Equals(nom))
                    emp.NbrHeures = x;
        }
    

    }
}

