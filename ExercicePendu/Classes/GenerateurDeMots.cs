using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePendu.Classes
{
    class GenerateurDeMots
    {

        public static  List<string> _motAleatoire = new ()
        {
            //"censure",
            //"croquis",
            //"taxi",
            //"sortie",
            //"gorrile",
            //"trottoir",
            //"mars",
            //"remplir",
            //"lanterne",
            //"facile",
            //"beau",
            //"drole",
            //"poutre",
            //"dinosaur",
            //"couille",
            //"zeub",
            //"rhododendron",
            //"patapouffe",
            "test",
        };

        public static List<string> MotAleatoire { get => _motAleatoire; set => _motAleatoire = value; }

        public static string SelectionMotAleatoire()
        {
            var rnd = new Random().Next(MotAleatoire.Count);
            return MotAleatoire[rnd];
        }
    }
}
