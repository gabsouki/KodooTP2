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
                Console.WriteLine("1. Ajouter un employé \n2. Voir la liste des employés");
                Console.WriteLine("3. Ajouter le total des ventes d'un employé Commercial \n4. Ajouter un objectif de vente pour un Superviseur");
                Console.WriteLine("5. Ajouter un nombre d'heures de travail pour un employé Tâche \n6. Calculer et afficher les salaires de tous les employés");
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
                            Console.WriteLine("Entre la fonction du nouvel employé \n" +
                            "1. Superviseur \t\t\t 2. Commercial\n" +
                            "3. Tâche \t\t\t 4. Bureau");
                            int reponse = Int32.Parse(Console.ReadLine());
                            string fonction="";

                            //Assignation de la fonction
                            switch (reponse)
                            {
                                case 1:
                                    {
                                        fonction = "Superviseur";
                                        break;
                                    }
                                case 2:
                                    {
                                        fonction = "Commercial";
                                        break;
                                    }
                                case 3:
                                    {
                                        fonction = "Tâche";
                                        break;
                                    }
                                case 4:
                                    {
                                        fonction = "Bureau";
                                        break;
                                    }
                            }

                            //Inscription des employés
                            switch (reponse)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Entrez le nom de l'employé:");
                                        string nom = Console.ReadLine();
                                        Console.WriteLine("Entrez le matricule de l'employé:");
                                        int matricule = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Entre le numéro de cellulaire de l'employé:");
                                        string tel = Console.ReadLine();
                                        Console.WriteLine("Entrer le salaire annuel de l'employé en dollars:");
                                        float salaire = float.Parse(Console.ReadLine());
                                        Console.WriteLine("L'opération a été effectuée, appuyez sur une touche pour continuer.");
                                        Koodo.Embauche(new Superviseur(fonction, nom, matricule, tel, salaire));
                                        Console.ReadKey();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Entrez le nom de l'employé:");
                                        string nom = Console.ReadLine();
                                        Console.WriteLine("Entrez le matricule de l'employé:");
                                        int matricule = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Entre le numéro de cellulaire de l'employé:");
                                        string tel = Console.ReadLine();
                                        Console.WriteLine("Entrer le salaire annuel de l'employé en dollars:");
                                        float salaire = float.Parse(Console.ReadLine());
                                        Console.WriteLine("L'opération a été effectuée, appuyez sur une touche pour continuer.");
                                        Koodo.Embauche(new Commercial(fonction, nom, matricule, tel, salaire));
                                        Console.ReadKey();
                                        break;

                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Entrez le nom de l'employé:");
                                        string nom = Console.ReadLine();
                                        Console.WriteLine("Entrez le matricule de l'employé:");
                                        int matricule = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Entre le numéro de cellulaire de l'employé:");
                                        string tel = Console.ReadLine();
                                        Console.WriteLine("Entrer le taux horaire de l'employé en dollars:");
                                        float salaire = float.Parse(Console.ReadLine());
                                        Console.WriteLine("L'opération a été effectuée, appuyez sur une touche pour continuer.");
                                        Koodo.Embauche(new Tache(fonction, nom, matricule, tel, salaire));
                                        Console.ReadKey();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Entrez le nom de l'employé:");
                                        string nom = Console.ReadLine();
                                        Console.WriteLine("Entrez le matricule de l'employé:");
                                        int matricule = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Entre le numéro de cellulaire de l'employé:");
                                        string tel = Console.ReadLine();
                                        Console.WriteLine("Entrer le salaire annuel de l'employé en dollars:");
                                        float salaire = float.Parse(Console.ReadLine());
                                        Console.WriteLine("L'opération a été effectuée, appuyez sur une touche pour continuer.");
                                        Koodo.Embauche(new Bureau(fonction, nom, matricule, tel, salaire));
                                        Console.ReadKey();
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Cette fonction n'existe pas. Appuyez sur une touche pour continuer.");
                                        Console.ReadKey();
                                        break;
                                    }
                            }


                            break;
                        }
                    case 2:
                        {
                            Koodo.Afficher();
                            Console.WriteLine("Appuyez sur une touche pour continuer.");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Entrez le nom de l'employé concerné:");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez le total des ventes de l'employé concerné:");
                            Koodo.Ventes(nom, float.Parse(Console.ReadLine()));
                            Console.WriteLine("Appuyez sur une touche pour continuer.");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Entrez le nom de l'employé concerné:");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez l'objectif de ventes de l'employé concerné:");
                            Koodo.Objectif(nom, float.Parse(Console.ReadLine()));
                            Console.WriteLine("Appuyez sur une touche pour continuer.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Entrez le nom de l'employé concerné:");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Entrez le nombre d'heures travaillées de l'employé concerné:");
                            Koodo.Heures(nom, float.Parse(Console.ReadLine()));
                            Console.WriteLine("Appuyez sur une touche pour continuer.");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {

                            Koodo.Salaire();
                            Console.WriteLine("Appuyez sur une touche pour continuer.");
                            Console.ReadKey();

                            break;
                            
                        }
                    case 7:
                        {
                            Koodo.Renitialiser();
                            Console.WriteLine("Les objectifs de ventes, les nombres d'heures travaillées le total des ventes a été rénitialisé. Appuyez sur une touche pour continuer.");
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
            Console.WriteLine("Merci d'avoir utilisé ce système! Appuyez sur une touche pour continuer.");
            Console.ReadKey();
        }
    }
}


            



    


