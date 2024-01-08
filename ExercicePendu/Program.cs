using ExercicePendu.Classes;

Pendu pendu = new Pendu();

do
{
    Console.WriteLine("Mot à trouver " + pendu.Masque);
    Console.Write("Choisissez une lettre : ");
    char userInput = Console.ReadLine()[0];
    pendu.TestChar(userInput);
    Console.WriteLine("\n");
} while (!pendu.TestWin());

if (pendu.Mot == pendu.Masque)
{
    Console.WriteLine("Bravo tu as gagné !!!!!!!!!!!!!");
    Console.WriteLine("Le mot était " + pendu.Mot);
}
if (pendu.NbEssaie == 0)
    Console.WriteLine("T'as perdu");
