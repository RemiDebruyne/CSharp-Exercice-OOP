using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePile.Classes
{
    internal class Personne
    {
        private string _name;
        private string _surname;
        private string _age;

        public Personne(string name, string surname, string age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
    }
}
