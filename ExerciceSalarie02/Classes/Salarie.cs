using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSalarie02.Classes
{
    internal class Salarie
    {
        //Attributs
        private static int _nombreEmployes;
        private static int _SalaireTotale;
        private static int _moyenneSalaire;
        public int _salaire;
        public string _nom;
        public string _service;
        public string _categorie;
        public string _matricule;

        //Properties
        public static int NombreEmployes { get; set; }
        public static int SalaireTotale { get; set; }
        public string Matricule { get; set; }
        public string Service { get; set; }
        public string Categorie { get; set; }




        //Porperty with get only 
        public static double MoyenneSalaire => SalaireTotale / NombreEmployes;
        public string Nom { get; set; }
        public int Salaire
        {
            get
            {
                return _salaire;
            }
            set
            {
                SalaireTotale = SalaireTotale - Salaire + value;
                _salaire = value;

            }
        }





        static public void AfficherInfosEntreprises()
        {
            Console.WriteLine("Le nombre total de salariés est de " + NombreEmployes + " et leur salaires est de " + SalaireTotale + " euros");
        }

        //Override ToString
        public override string ToString()
        {
            return ("Le salaire de l'employé " + Nom + " matricule " + Matricule + " est de " + Salaire + " poutres");

        }
        //Affiche les infos des employés
        public virtual void AfficherSalaires()
        {
            Console.WriteLine(this);
        }

        static public void AfficherMoyenneSalaire()
        {
            Console.WriteLine(MoyenneSalaire);
        }



        public Salarie()
        {
            Nom = "Jean";
            Salaire = 8;
            Matricule = "M000";
            Service = "S000";
            Categorie = "C000";
            NombreEmployes++;
        }

        public Salarie(string nom, int salaire, string service, string categorie) : this()
        {
            Nom = nom;
            Salaire = salaire;
            Matricule = Guid.NewGuid().ToString();
            Service = service;
            Categorie = categorie;
        }


    }
}

