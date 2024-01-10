using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeerciceFigure.Classes
{
    internal class Point
    {
        private double _posX;
        private double _posY;

        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }

        public override string ToString()
        {
            //return $"Mon point d'origine est : {PosX};{PosY}";
            return $"{PosX};{PosY}";
        }
        public Point(double posX, double posY)
        {
            PosX = posX;
            PosY = posY;
        }
    }
}
