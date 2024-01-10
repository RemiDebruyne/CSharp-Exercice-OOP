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
        private Point _pointA;
        private Point _pointB;
        private Point _pointC;
        private Point _pointD;

        public Point PointA { get => _pointA; set => _pointA = value; }
        public Point PointB { get => _pointB; set => _pointB = value; }
        public Point PointC { get => _pointC; set => _pointC = value; }
        public Point PointD { get => _pointD; set => _pointD = value; }

        //Calcule l'affichage en fonction de l'origine
        public override string ToString()
        {
           return $"Cordoonées du carré ABCD (Coté = {_cote}\n" +
                $"A = {Origine.PosX};{Origine.PosY}\n" + 
                $"B = {Origine.PosX + _cote};{Origine.PosY}\n" +
                $"C = {Origine.PosX + _cote};{Origine.PosY + _cote}\n" +
                $"D = {Origine.PosX + _cote};{Origine.PosY}";
        }

        // Affiche les coordonnées via les coordonnées des points directement
        public void Afficher()
        {
            Console.WriteLine($"{PointA}\n" +
                $"{PointB}\n" +
                $"{PointC}\n" +
                $"{PointD}\n");
        }

        public Carre(double posX, double posY, double cote) : base(posX, posY)
        {
            _cote = cote;

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
