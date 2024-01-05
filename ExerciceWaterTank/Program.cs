using ExerciceWaterTank.Classes;

WaterTank citerne1 = new WaterTank(20, 5, "citerne 1");
WaterTank citerne2 = new WaterTank(10, 3, "citerne 2");

List<WaterTank> waterTanks = new List<WaterTank>()
{
    citerne1,
    citerne2,
};

citerne1.AfficherPoidTotal();
citerne2.AfficherPoidTotal();
Console.WriteLine("---------------------------------------------------------------");
citerne1.AfficherQuantiteActuel();
citerne2.AfficherQuantiteActuel();
Console.WriteLine("---------------------------------------------------------------");
WaterTank.QuantiteTotalToutesLesCiternes();
Console.WriteLine("---------------------------------------------------------------");
citerne1.RemplirLaCiterne(20);
citerne2.ViderLaCiterne(6);
Console.WriteLine("---------------------------------------------------------------");
citerne1.AfficherQuantiteActuel();
citerne2.AfficherQuantiteActuel();



//citerne1.AfficherPoidTotal();

