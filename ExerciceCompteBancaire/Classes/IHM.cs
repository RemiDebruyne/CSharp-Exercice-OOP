using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCompteBancaire.Classes
{
    internal class IHM
    {
        public static void AfficherMenu()
        {
            Client client = new("Macron", "Emanuelle", 01, "00 00 00 00 00");

            Console.WriteLine("=== Menu Principal ===");
            Console.WriteLine("1. Lister les comptes\n" +
                "2. Créer un compte bancaire\n" +
                "3. Effectuer un dépot\n" +
                "4. Effectuer un retrait\n" +
                "5. Afficher les opérations et le solde\n" +
                "6. Quiiter");

            Console.Write("Que voulez-vous faire ? : ");
            switch (Console.ReadLine())
            {
                case "1":
                    client.AfficherComptes();
                    break;
                case "2":
                    Console.WriteLine("1. Créer un compte courant\n" +
                        "2. Créer un compte épargne\n" +
                        "3. Créer un compte payant\n" +
                        "0. Annuler la création de compte\n");
                    switch (Console.ReadLine())
                    {
                        case "1":

                            break;
                        case "2":

                            break;
                        case "3":
                            break;
                        case "0":
                            break;
                        default:
                            break;
                    }
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Erreur, veuillez réessayer");
                    break;
            }
        }
    }
}
