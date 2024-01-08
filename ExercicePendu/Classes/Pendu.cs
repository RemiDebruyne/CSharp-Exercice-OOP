using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicePendu.Classes;

namespace ExercicePendu.Classes
{
    internal class Pendu
    {
        private string _mot;
        private int _nbEssaie = 10;
        private string _masque;
        //private char _userInput;


        public string Masque { get => _masque; set => _masque = value; }
        public int NbEssaie { get => _nbEssaie; set => _nbEssaie = value; }
        public string Mot { get => _mot; set => _mot = value; }
        //public char UserInput { get => _userInput; set => _userInput = value; }

        public Pendu()
        {
            GenerateurDeMots list = new GenerateurDeMots();

            Mot = GenerateurDeMots.SelectionMotAleatoire();
            Masque = GenererMasque();
            NbEssaie = _nbEssaie;
        }

        public void TestChar(char userInput)
        {
            string tmpMask = "";

            bool flag = false;

            for (int i = 0; i < Mot.Length; i++)
            {
                if (Mot[i] == userInput)
                {
                    tmpMask += userInput;
                    flag = true;
                }
                else
                    tmpMask += Masque[i];
            }

            if(!flag)
            {
                NbEssaie--;
            }

            Masque = tmpMask;

        }

        public bool TestWin()
        {
            bool testWin = Masque == Mot || NbEssaie <= 0 ? true : false;
            return testWin;
        }

        public string GenererMasque()
        {
            //string stringMasquee = "";
            //for (int i = 0; i < Mot.Length; i++)
            //{
            //    stringMasquee += Mot.Replace(Mot[i], '*'); Ne fonctionne pas car que je viens concat "" + mon mot avec le charactère i remplacé par un * 
            //    stringMasquee += "*";
            //}
            //return = stringMasquee;


            string stringMasquee = "";

            foreach (char lettre in Mot)
            {
                stringMasquee += "*";
            }

            return stringMasquee;
        }
    }
}
