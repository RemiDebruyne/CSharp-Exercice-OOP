using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSalarie02.Classes
{
    internal class Commercial : Salarie
    {
        private float _ca;
        private int _commission;

        public float Ca { get => _ca; set => _ca = value; }
        public int Commission { get => _commission; set => _commission = value; }

        public Commercial(string nom, int salaire, string service, string categorie, int ca, int commission) : base(nom, salaire, service, categorie)
        {
            Nom = nom;
            Salaire = salaire;
            Service = service;
            Categorie = categorie;
            Ca = ca;
            Commission = commission;

        }
        public override string ToString()
        {
            return ("Le salaire de l'employé " + Nom + " matricule " + Matricule + " est de " + Salaire + (Ca * Commission / 100) + " poutres");
        }
        override public void AfficherSalaires()
        {
            Console.WriteLine(this);
        }
    }
}
