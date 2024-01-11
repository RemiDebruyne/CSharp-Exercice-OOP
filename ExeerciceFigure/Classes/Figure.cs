using ExeerciceFigure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeerciceFigure.Classes;

namespace ExeerciceFigure.Classes
{
    internal abstract class Figure : IDeplacable
    {
        private Point _origine;

        internal Point Origine { get => _origine; set => _origine = value; }

        // Permet un héritage dans chaque figure pour déplacer chaque point individuellement s'ils sont déclarés en attributs
        public abstract void Deplacement(double pointX, double pointY);

        // Déplace uniquement l'origine, on peut afficher les positions des points en les calculant directement à l'affichage
        //public abstract void Deplacement(double pointX, double pointY)
        //{
        //    Origin.PosX += pointX;
        //    Origin.PosY += PointY
        //}
        
        protected Figure(double posX, double posY)
        {
            _origine = new(posX, posY);
        }
    }
}
