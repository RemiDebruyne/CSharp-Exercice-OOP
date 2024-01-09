using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceCompteBancaire.Classes;

namespace ExerciceCompteBancaire.Classes
{
    internal abstract class CompteBancaire
    {
        protected string _nom;
        protected float _solde;
        protected Client _client;
        protected List<Operation> _operations = new List<Operation>();

        public float Solde { get => _solde; set => _solde = value; }
        public Client Client { get => _client; set => _client = value; }
        public List<Operation> Operations { get => _operations; set => _operations = value; }
        public string Nom { get => _nom; set => _nom = value; }

        
        public CompteBancaire(string nom, Client client)
        {
            Nom = nom;
            Solde = 0;
            Client = client;
            Operations = new();

        }
    }
}
