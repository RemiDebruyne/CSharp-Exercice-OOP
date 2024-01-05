using ExerciceSalarie;
using ExerciceSalarie.Classes;

Salarie jean = new Salarie();
Salarie chloe = new Salarie("Chloé", 10000, "marketing", "cadre");
Salarie marie = new Salarie("Marie", 10000, "IT", "salarié");
Salarie pierre = new Salarie("Pierre", 10000, "commercial", "cadre");

List<Salarie> list = new List<Salarie>
{
    jean,
    chloe,
    marie,
    pierre,
};

foreach (Salarie salarie in list)
{
    salarie.AfficherInfosEmployes();
}

Console.WriteLine();

Salarie.AfficherInfosEntreprises();

list[1].Salaire = 0;

Console.WriteLine();
chloe.AfficherInfosEmployes();
Console.WriteLine();
Salarie.AfficherInfosEntreprises();
Console.WriteLine();
Salarie.AfficherMoyenneSalaire();
