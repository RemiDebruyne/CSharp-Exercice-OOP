using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCompteBancaire.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        public CompteEpargne(string nom, Client client) : base(nom, client)
        {
        }
    }
}
