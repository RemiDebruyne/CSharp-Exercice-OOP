using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeerciceFigure.Classes
{
    internal class Rectangle : Figure
    {
        private double _longueur;
        private double largeur;

        public Rectangle(double posX, double posY) : base(posX, posY)
        {
        }
    }
}
