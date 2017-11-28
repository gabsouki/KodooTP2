using System;

namespace Koodo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Création de la liste
            Employes Koodo = new Employes();

            //Menu
            int choix;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Ajouter un employé \t\t\t\t\t 2. Voir la liste des employés");
                Console.WriteLine("3. Ajouter le total des ventes d'un employé \t\t 4. Ajouter un objectif de vente");
                Console.WriteLine("5. Ajouter un nombre d'heures de travail \t\t 6. Calculer et afficher les salaires de tous les employés");
                Console.WriteLine("7. Préparer le programme au prochain calcul de paie");
                Console.WriteLine("0. Quitter \n\n\n");

                Console.WriteLine("Que voulez-vous faire?");
                choix = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (choix)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Entrez le nom de l'employé");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez le matricule de l'employé");
                            int matricule = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Entre le numéro de cellulaire de l'employé");
                            string tel = Console.ReadLine();
                            Console.WriteLine("Entrer le salaire de l'employé en dollars (taux fixe ou taux horaire)");
                            float salaire = float.Parse(Console.ReadLine());
                            Console.WriteLine("Entre la fonction du nouvel employé \n" +
                            "1 (Superviseur) \t\t\t 2 (Commercial)\n" +
                            "3 (Tâche) \t\t\t\t 4 (Bureau)");

                            switch (Int32.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    {
                                        Koodo.Embauche(new Superviseur(nom, matricule, tel, salaire));
                                        break;
                                    }
                                case 2:
                                    {
                                        Koodo.Embauche(new Commercial(nom, matricule, tel, salaire));
                                        break;

                                    }
                                case 3:
                                    {
                                        Koodo.Embauche(new Tache(nom, matricule, tel, salaire));
                                        break;
                                    }
                                case 4:
                                    {
                                        Koodo.Embauche(new Bureau(nom, matricule, tel, salaire));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Cette fonction n'existe pas");
                                        Console.ReadKey();
                                        break;
                                    }
                            }


                            break;
                        }
                    case 2:
                        {
                            Koodo.Afficher();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Entrez le nom de l'employé concerné");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez le total des ventes de l'employé concerné");
                            Koodo.Ventes(nom, float.Parse(Console.ReadLine())); 
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Entrez le nom de l'employé concerné");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez l'objectif de ventes de l'employé concerné");
                            Koodo.Objectif(nom, float.Parse(Console.ReadLine()));


                            break;
                        }



                    case 5:
                        {
                            Console.WriteLine("Entrez le nom de l'employé concerné");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez le nombre d'heures travaillées de l'employé concerné");
                            Koodo.Heures(nom, float.Parse(Console.ReadLine()));
                            break;
                        }
                    case 6:
                        {

                            Koodo.Salaire();
                            Console.ReadKey();

                            break;
                            
                        }
                    case 7:
                        {
                            Koodo.Renitialiser();
                            Console.WriteLine("Les objectifs de ventes, les nombres d'heures travaillées le total des ventes a été rénitialisé");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {

                            break;
                        }
                }
            } while (choix != 0);
            Console.Clear();
            Console.WriteLine("Merci d'avoir utilisé ce système!");
            Console.ReadKey();
        }
    }
}


            



    


