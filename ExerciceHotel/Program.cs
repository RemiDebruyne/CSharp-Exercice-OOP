using ExerciceHotel.Classes;
using System.ComponentModel;



// Create a new Hotel
Console.Write("Quel est le nom de l'hotel? ");
string hotelName = Console.ReadLine();
Console.WriteLine("Combien de chambre doit avoir l'hotel ? : ");
int nBOfRooms;
if (!int.TryParse(Console.ReadLine(), out nBOfRooms))
    Console.WriteLine("Message incorrecte");
Hotel myHotel = new Hotel(hotelName, nBOfRooms);
Console.WriteLine(hotelName + " créé avec succès !\n");


new Client("Dupont", "Jean", "06 50 34 61 32", myHotel, 1);
new Client("Dupont", "Pierree", "06 50 34 61 32", myHotel, 2);

//myHotel.ReadClientList();


while (true)
{
    Console.WriteLine("=== Menu Principal ===");
    Console.WriteLine("1. Ajouter une liste de client\n" +
        "2. Afficher la liste de client\n" +
        "3. Afficher les reservations d'un client\n" +
        "4.Ajouter une réservation\n" +
        "5. Annuler une réservation\n" +
        "6. Afficher la liste de réservation\n" +
        "0. Quitter");


    char input = Console.ReadLine()[0];
    switch (input)
    {
        case '1': // Add client
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            int numberOfRooms;
            while(!int.TryParse(Console.ReadLine(), out numberOfRooms));
            Console.WriteLine("Valeur incorrecte");

            new Client(firstName, lastName, phoneNumber, myHotel, numberOfRooms);
            break;
    }

}