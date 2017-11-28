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
                
                Console.WriteLine("test");
                Console.Clear();
                Console.WriteLine("1. Ajouter un employé \t\t\t\t\t 2. Voir la liste des employés");
                Console.WriteLine("3. Ajouter le nombre de vente d'un employé \t\t 4. Ajouter un objectif de vente");
                Console.WriteLine("5. Ajouter un nombre d'heure de travail \t\t 6. Calculer et afficher les salaires de tous les employés");
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
                            "S (Superviseur) \t\t\t C (Commercial)\n" +
                            "T (Tâche) \t\t\t\t B (Bureau)");

                            string fonction = Console.ReadLine();
                            fonction.ToLower();
                            switch (fonction)
                            {
                                case "s":
                                    {
                                        Koodo.Embauche(new Superviseur(nom, matricule, tel, salaire));
                                        break;
                                    }
                                case "b":
                                    {
                                        Koodo.Embauche(new Bureau(nom, matricule, tel, salaire));
                                        break;

                                    }
                                case "c":
                                    {
                                        Koodo.Embauche(new Commercial(nom, matricule, tel, salaire));
                                        break;
                                    }
                                case "t":
                                    {
                                        Koodo.Embauche(new Tache(nom, matricule, tel, salaire));
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Cette fonction n'existe pas");
                                        break;
                                    }
                            }


                            break;
                        }
                    case 2:
                        {
                            Koodo.Afficher();
                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            Console.WriteLine("Entrez le nom de l'employé concerné");
                            string prenomo = Console.ReadLine();
                            Console.WriteLine("Entrez l'objectif de ventes de l'employé concerné");
                            float objectifo = float.Parse(Console.ReadLine());


                            break;
                        }



                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {

                            Koodo.Salaire();

                            break;
                            
                        }
                    case 7:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choix non valide");
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


            



    


