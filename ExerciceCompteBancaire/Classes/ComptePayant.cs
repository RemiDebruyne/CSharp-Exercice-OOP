using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCompteBancaire.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        public ComptePayant(string nom, Client client) : base(nom, client)
        {
        }
    }
}
