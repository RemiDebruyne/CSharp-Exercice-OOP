using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp01.Classes
{
    internal class Dinosaur
    {
        // Attributs
        private int _age;
        private int _espece;
        private double _poids;
        private int _nbPattes;
        private bool _peutVoler = false;


        // Proriétés
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        // Ou
        public int Espece { get => _espece; set => _espece = value; }
        public double Poids
        {
            get
            {
                Console.WriteLine(value: "_poids à été récupéré, il vaut" + _poids);
                return _poids;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("la valeur passée au poids est invalide. Je la met ) 100kg");
                    _poids = 100;
                }
                _poids = value;
            }
        }
        public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
        public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }
        
        
        //public string AgeEspace { get => $"{_age} {_espece}";} une syntaxe
        public string AgeEspace { get => $"{Age} {Espece}";} //Deuxième syntaxe

        //Propriétés avec des attributs private implicite
        public string RegimeAlimentaire { get; set; } = "Herbivore";
    }
}
