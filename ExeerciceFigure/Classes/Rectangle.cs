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
        private double _largeur;
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;
        private Point _pointD;

        public Point PointA { get => _pointA; set => _pointA = value; }
        public Point PointB { get => _pointB; set => _pointB = value; }
        public Point PointC { get => _pointC; set => _pointC = value; }
        public Point PointD { get => _pointD; set => _pointD = value; }
        public Rectangle(double posX, double posY, double longueur, double largeur) : base(posX, posY)
        {
            _longueur = longueur;
            _largeur = largeur;

            //A
            PointA.PosX = Origine.PosX;
            PointA.PosY = Origine.PosY;

            //B
            PointB.PosX = Origine.PosX;
            PointB.PosY = Origine.PosY + largeur;

            //C
            PointC.PosX = Origine.PosX + longueur;
            PointC.PosY = Origine.PosY + largeur;

            //D
            PointD.PosX = Origine.PosX + longueur;
            PointD.PosY = Origine.PosY;
        }

        public override void Deplacement(double pointX, double pointY)
        {
            PointA.PosX += pointX;
            PointA.PosY += pointY;

            PointB.PosX += pointX;
            PointB.PosY += pointY;

            PointC.PosX += pointX;
            PointC.PosY += pointY;

            PointD.PosX += pointX;
            PointD.PosY += pointY;
        }

    }
}
