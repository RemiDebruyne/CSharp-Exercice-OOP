using ExerciceCompteBancaire.Classes;

//protected CompteBancaire(float solde, string client, List<Operation> operations)
//{
//    Solde = solde;
//    Client = client;
//    Operations = operations;
//}

// public Client(string nom, string prenom, int id, List<CompteBancaire> listComptes, string telephone)

//Operations test
Operation operation = new Operation(1, 1, Statut.DEPOT);
Operation deuxiemeOperation = new Operation(1, 1, Statut.RETRAIT);

List<Operation> mesOperations = new()
{
    operation,
    deuxiemeOperation
};



// Client test
Client client = new("Debruyne", "remi", 01, "07 50 34 51 63");

client.AfficherComptes();


// Comptes test
CompteCourant compteCourant01 = new("Premier compte courant", client);
List<CompteBancaire> mesComptes = new()
{
    compteCourant01
};