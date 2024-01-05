using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceWaterTank.Classes
{
    internal class WaterTank
    {
        private static double _quantiteDansToutesLesCiternes;
        private static int _nombreDeCiterne;
        private double _poidTotal;
        //private static double _poidToutesLesCirenes;
        private double _quantiteActuel;

        private double _capaciteTotal;

        private string _nom;

        public string Nom { get => _nom; set => _nom = value; }

        public double PoidAVide;
        public double CapaciteTotale { get => _capaciteTotal; set => _capaciteTotal = value; }
        public double QuantiteActuel
        {
            get
            {
                return _quantiteActuel;
            }
            set
            {
                QuantiteDansToutesLesCiternes = QuantiteDansToutesLesCiternes - QuantiteActuel + value;
                _quantiteActuel = value;
                PoidTotal = QuantiteActuel + PoidAVide;
                ;

            }
        }

        public static int NombreDeCiterne { get => _nombreDeCiterne; set => _nombreDeCiterne = value; }
        public double PoidTotal { get => _poidTotal; set => _poidTotal = value; }
        //public static double PoidToutesLesCirenes { get => _poidToutesLesCirenes; set => _poidToutesLesCirenes = value; }
        public static double QuantiteDansToutesLesCiternes { get => _quantiteDansToutesLesCiternes; set => _quantiteDansToutesLesCiternes = value; }

        public void RemplirLaCiterne(double litre)
        {
            QuantiteActuel += litre;

            if (QuantiteActuel > CapaciteTotale)
            {
                Console.WriteLine($"Quantité d'eau dans la {Nom} après ajout de {litre} : {CapaciteTotale}/{CapaciteTotale}" +
                    $"\nExcès d'eau récupéré = {QuantiteActuel - CapaciteTotale}");

            }
            else
                Console.WriteLine($"Quantité d'eau dans la {Nom} après ajout de {litre}: {QuantiteActuel}/{CapaciteTotale}");
        }

        public void ViderLaCiterne(double litre)
        {
            QuantiteActuel -= litre;

            if (QuantiteActuel < CapaciteTotale)
                Console.WriteLine($"Quantité d'eay dans la {Nom} après retrait de {litre} : 0/{CapaciteTotale}" +
                    $"\nExcès d'eau récupéré = {Math.Abs(0 - QuantiteActuel)}");
            else
                Console.WriteLine($"Quantité d'eau dans la {Nom} après retrait {litre}: {QuantiteActuel}/{CapaciteTotale}");

        }

        public void AfficherQuantiteActuel()
        {
            if (0 > QuantiteActuel)
                Console.WriteLine($"Quantité actuelle de la {Nom}: 0/{CapaciteTotale}");
            else if (QuantiteActuel > CapaciteTotale)
                Console.WriteLine($"Quantité actuelle de la {Nom}: {CapaciteTotale}/{CapaciteTotale} ");
            else
                Console.WriteLine($"Quantité actuelle de la {Nom}: {QuantiteActuel}");
        }

        public void AfficherPoidTotal()
        {
            Console.WriteLine($"Le poids total de la {Nom} : {PoidTotal}");
        }

        public static void QuantiteTotalToutesLesCiternes()
        {
            Console.WriteLine($"Quantité d'eau dans toutes les citernes : {QuantiteDansToutesLesCiternes}");
        }


        public WaterTank(double capaciteTotale, double quantiteDEau, string nom)
        {
            NombreDeCiterne++;
            PoidAVide = 10;
            CapaciteTotale = capaciteTotale;    
            QuantiteActuel = quantiteDEau;
            Nom = nom;
        }

    }
}
