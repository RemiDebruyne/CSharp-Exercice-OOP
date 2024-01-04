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
        private static int _nombreDeDinos = 0;

        // Property
        public string Nom { get; set; } = "Dinosaur par défaut";
        public int Age { get; set; }
        public string Espece { get; set; }
        public bool PeutVoler { get; set; }

        // Est équivalent à :
        // public static int NombreDeDinos { get => _nombreDeDinos; }
        //Ici on ne veut pas de setter car l'information ne doit pas pouvoir être changée de l'extérieur
        public static int NombreDeDinos => _nombreDeDinos;


        public Dinosaur(string nom, int age, string espece, bool peutVoler = false) { }
    }
}
