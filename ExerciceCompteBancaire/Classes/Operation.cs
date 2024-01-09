using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCompteBancaire.Classes
{
    internal class Operation
    {
        private static int _count;
        private int _numero;
        private float _montant;
        private Statut _statut;
        public Operation(float numero, float montant, Statut statut)
        {
            _numero = ++_count;
            _montant = montant;
            _statut = statut;
        }
    }
}
