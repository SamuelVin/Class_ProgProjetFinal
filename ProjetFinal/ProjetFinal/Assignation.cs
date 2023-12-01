using Microsoft.WindowsAppSDK.Runtime.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class Assignation
    {

        String matricule;
        String numeroProjet;
          int  nbrHeure;
          double salPay ;

        public Assignation()
        {
            this.Matricule = "";
            this.NumeroProjet = "";
            this.NbrHeure = 0;
            this.SalPay = 0.0;
             
        }

        public Assignation( string _matricule, string _numeroProjet, int _nbrHeure, double _salPay)
        {
            this.Matricule = _matricule;
            this.NumeroProjet = _numeroProjet;
            this.NbrHeure = _nbrHeure;
            this.SalPay = _salPay;
           
        }


        public string Matricule { get => matricule; set => matricule = value; }
        public string NumeroProjet { get => numeroProjet; set => numeroProjet = value; }
        public int NbrHeure { get => nbrHeure; set => nbrHeure = value; }

        public double SalPay { get => salPay; set => salPay= value; }




        public override string ToString()
        {
            return matricule + " " + numeroProjet + " " + nbrHeure + " " + salPay;
        }



    }
}
