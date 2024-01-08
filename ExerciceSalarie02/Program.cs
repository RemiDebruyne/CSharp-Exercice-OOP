using ExerciceSalarie02.Classes;

Console.WriteLine("--- Gestion des employés ---");

while (true)
{
    Console.WriteLine("1--- Ajouter un employé");
    Console.WriteLine("2--- Afficher le salaire des employés");
    Console.WriteLine("3--- Rechercher un employé");
    Console.WriteLine("0--- Quitter");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            Console.WriteLine("--- Ajouter un employé ---");
            switch (Console.ReadLine())
            {
                case "1":

                    break;
                case "2":
                    break;
                case "3":
                    break;

            }
            break;
        case "2":
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