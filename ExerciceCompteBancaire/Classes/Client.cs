﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExerciceCompteBancaire.Classes
{
    internal class Client
    {
        private string _nom;
        private string _prenom;
        private int _id;
        private List<CompteBancaire> _listComptes = new List<CompteBancaire>();
        private string _telephone;

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int Id { get => _id; set => _id = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }
        internal List<CompteBancaire> ListComptes { get => _listComptes; set => _listComptes = value; }

        public override string ToString()
        {
            string tmp = "Vos comptes sont : \n";
            foreach (CompteBancaire compteBancaire in ListComptes)
            {
                tmp += "\t" + compteBancaire.Nom + "\n";
            }
            return tmp ;
        }
        public void AfficherComptes()
        {
            if (ListComptes.Count > 0)
            {
                Console.WriteLine(this);

            }
        }

        public Client(string nom, string prenom, int id, string telephone)
        {
            _nom = nom;
            _prenom = prenom;
            _id = id;
            _listComptes = new();
            _telephone = telephone;
        }
    }
}
