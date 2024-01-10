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
        private double _baseT;
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;


        internal Point PointA { get => _pointA; set => _pointA = value; }
        internal Point PointB { get => _pointB; set => _pointB = value; }
        internal Point PointC { get => _pointC; set => _pointC = value; }

        public override void Deplacement(double pointX, double pointY)
        {
            PointA.PosX += pointX;
            PointA.PosY += pointY;

            PointB.PosX += pointX;
            PointB.PosY += pointY;

            PointC.PosX += pointX;
            PointC.PosY += pointY;

        }
        public Triangle(double posX, double posY, double hauteur, double baseT) : base(posX, posY)
        {
            _hauteur = hauteur;
            _baseT = baseT;
            PointA.PosX = posX;
            PointA.PosY = posY;

            PointB.PosX = posX + baseT;
            PointB.PosY =posY;

            PointC.PosX = posX + (baseT / 2);
            PointC.PosY = posY;
        }
    }
}
