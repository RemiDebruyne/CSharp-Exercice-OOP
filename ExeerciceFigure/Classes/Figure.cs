﻿using ExeerciceFigure.Interfaces;
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

        // 
        public abstract void Deplacement(double pointX, double pointY);
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
