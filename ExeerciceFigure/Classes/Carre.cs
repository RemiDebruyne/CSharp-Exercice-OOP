using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeerciceFigure.Classes
{
    internal class Carre : Figure
    {
        private double _cote;
        //private double _pointA;
        //private double _pointB;
        //private double _pointC;
        //private double _pointD;

        public override string ToString()
        {
           return $"Cordoonées du carré ABCD (Coté = {_cote}\n" +
                $"A = {Origine.PosX};{Origine.PosY}\n" + 
                $"B = {Origine.PosX + _cote};{Origine.PosY}\n" +
                $"C = {Origine.PosX + _cote};{Origine.PosY + _cote}\n" +
                $"D = {Origine.PosX + _cote};{Origine.PosY}";
        }

        public Carre(double posX, double posY, double cote) : base(posX, posY)
        {
            _cote = cote;
        }
    }
}
