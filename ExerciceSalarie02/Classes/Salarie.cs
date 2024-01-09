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
        private static List<Salarie> _mesEmployes = new List<Salarie>(20);
        private static int _SalaireTotale;
        private static int _moyenneSalaire;
        protected int _salaire;
        protected string _nom;
        protected string _service;
        protected string _categorie;
        protected int _matricule;
        


        //Properties
        public static int NombreEmployes { get; set; }
        public static int SalaireTotale { get; set; }
        public int Matricule { get; set; }
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

        internal static List<Salarie> MesEmployes { get => _mesEmployes; set => _mesEmployes = value; }

        static public void AfficherInfosEntreprises()
        {
            Console.WriteLine("Le nombre total de salariés est de " + NombreEmployes + " et leur salaires est de " + SalaireTotale + " euros");
        }

        //Override ToString
        public override string ToString()
        {
            return ($"Nom : {Nom}" +
                $"Salaire : {Salaire}" +
                $"Matricule : {Matricule}" +
                $"Service : {Service}" +
                $"Categorie : {Categorie}");

        }
        //Affiche les infos des employés
        public virtual void AfficherSalaires()
        {
            Console.WriteLine("Le salaire de l'employé " + Nom + " matricule " + Matricule + " est de " + Salaire + " poutres");
        }

        static public void AfficherMoyenneSalaire()
        {
            Console.WriteLine(MoyenneSalaire);
        }

        static public void CreerEmploye(bool isCommercial) //paramtres = les params du cosntructeur, soit : nom, salaire, categorie ...
        {
            Console.WriteLine("Quelle est le nom de votre employé");
            string nom = Console.ReadLine();

            Console.WriteLine("Quelle est le salaire de votre employé");
            if (!int.TryParse(Console.ReadLine(), out int salaire))
                Console.WriteLine("valeur incorrecte");

            Console.WriteLine("Quelle est le service de votre employé");
            string service = Console.ReadLine();

            Console.WriteLine("Quelle est la catégorie de votre employé");
            string categorie = Console.ReadLine();

            if (isCommercial)
            {
                Console.WriteLine("Quelle est le chiffre d'affaire de votre employé");
                if (!int.TryParse(Console.ReadLine(), out int ca))
                    Console.WriteLine("valeur incorrecte");

                Console.WriteLine("Quelle est la commission ne % de votre employé");
                if (!int.TryParse(Console.ReadLine(), out int commission))
                    Console.WriteLine("valeur incorrecte");
                 MesEmployes.Add( new Commercial(nom, salaire, service, categorie, ca, commission))
            }
            MesEmployes.Add(new Salarie(nom, salaire, service, categorie));
        }



        public Salarie()
        {
            Nom = "Jean";
            Salaire = 8;
            Service = "S000";
            Categorie = "C000";
            Matricule = NombreEmployes++;
        }

        public Salarie(string nom, int salaire, string service, string categorie) : this()
        {
            Nom = nom;
            Salaire = salaire;
            Service = service;
            Categorie = categorie;
        }




    }
}

