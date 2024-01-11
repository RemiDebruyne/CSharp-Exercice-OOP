using ExercicePile.Classes;
using System.Runtime.CompilerServices;

//Pile<string> mesStrings = new Pile<string>(10);


//mesStrings.Add("zeub");

//mesStrings.Add("valeur à l'index 1");

//mesStrings.Read();

//Console.WriteLine("======================================\n");

//mesStrings.RemoveBydIndex(1);

//mesStrings.Read();

List<Pile<string>> stringPiles = new();
List<Pile<decimal>> decimalPiles = new();
List<Pile<Personne>> personnePiles = new();


Console.WriteLine("=== Menu Principal ===\n" +
    "1. Empiler\n" +
    "2. Dépiler\n" +
    "3. Récupérer à X\n" +
    "0. Quitter");

switch (Console.ReadLine())
{
    case "1":
        Pile<string>.GetAddType("empiler"); // 1/ string 2/decimal 3/ personne
        switch (Console.ReadLine())
        {
            case "1":

                if(stringPiles.Count == 0)
                     new Pile<string>();

                Pile<string> stringPile = stringPiles[stringPiles.Count - 1]
                Console.WriteLine("Que voulez vous ajouter");
                string input = Console.ReadLine();
                stringPile.Add(input);
                
                break;
            case "2":
                Pile<string> pile = stringPiles[stringPiles.Count - 1]
                Console.WriteLine("Que voulez vous ajouter");
                string input = Console.ReadLine();
                stringPile.Add(input);
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Valeur incorrecte");
                break;
        }
        break;
    case "2":
        Pile<string>.GetAddType("dépiler");

        break;
    case "3":
        Pile<string>.GetAddType("récupérer à X");

        break;
    case "0":
        break;
    default:
        Console.WriteLine("Valeur incorrecte");
        break;
}