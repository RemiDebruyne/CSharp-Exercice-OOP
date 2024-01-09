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
                        foreach (Salarie salarie in Salarie.MesEmployes)
                            break
                        break;
                    case "3":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Valeur incorrecte, utilisez 1/2/3/4");
                        break;
                }

            }


        }
    }
}
