using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeerciceFigure.Classes
{
    internal class Triangle : Figure
    {
        private double _hauteur;
        private double _base;

        public Triangle(double posX, double posY) : base(posX, posY)
        {
        }
    }
}
