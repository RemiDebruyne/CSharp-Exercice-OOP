using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSalarie02.Classes
{
    internal class IHM
    {
        static public void AfficherMenu()
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--- Gestion des employés ---");
                Console.WriteLine("1--- Ajouter un employé");
                Console.WriteLine("2--- Afficher le salaire des employés");
                Console.WriteLine("3--- Rechercher un employé");
                Console.WriteLine("0--- Quitter");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("--- Ajouter un employé ---");
                        Console.WriteLine("1) Salarié");
                        Console.WriteLine("2) Commerciale");
                        Console.WriteLine("3) Retour");

                        switch (Console.ReadLine())
                        {

                            case "1":
                                Salarie.CreerEmploye(false);
                                break;
                            case "2":
                                Salarie.CreerEmploye(true);
                                break;
                            case "3":
                                break;
                        }
                        break;
                    case "2":
                        foreach (Salarie s in Salarie.MesEmployes)
                            s.AfficherSalaires();
                        break;
                    case "3":
                        Console.Write("Nom de l'employé: ");
                        string nom = Console.ReadLine();
                        // Pour un seul emmployé
                        // Salarie found = Salarie.MesEmployes.Find(employes => employes.Nom.StartsWith(nom));
                        //found.AfficherSalaires();

                        // Pour trouver plusieurs employés
                        List<Salarie> found = Salarie.MesEmployes.Where(employe => employe.Nom.ToLower().StartsWith(nom.ToLower())).ToList();
                        if (found.Count > 0)
                            foreach (Salarie s in found)
                                s.AfficherSalaires();

                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Valeur incorrecte, utilisez 1/2/3/4");
                        break;
                }

            }


        }
    }
}
