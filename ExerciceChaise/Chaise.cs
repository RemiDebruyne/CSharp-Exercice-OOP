﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceChaise
{
    internal class Chaise
    {


        // Attributs

        private string _materiaux;
        private string _couleur;


        // Property
        public int NbPied { get; set; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        // Methods
        public void AfficherLesInfos()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Les infos de la chaise sont : " +
                "\n\tNombre de pieds : " + NbPied + "" +
                "\n\tMatériaux : " + Materiaux + "" +
                "\n\tCouleur : " + Couleur;
        }

        // Constructor
        public Chaise()
        {
            NbPied = 4;
            Materiaux = "bois";
            Couleur = "marron";

        }
        /// <summary>
        /// Constructor de chaise avec param (int nbPied, string materiaux, string couleur)
        /// </summary>
        public Chaise(int nbPied, string materiaux, string couleur)
        {
            this.NbPied = nbPied;
            this._materiaux = materiaux;
            this._couleur = couleur;
        }

    }

}
