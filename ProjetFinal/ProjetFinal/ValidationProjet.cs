using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class ValidationProjet
    {



        static ValidationProjet instance;
        public ValidationProjet() { }

        public static ValidationProjet getInstance()
        {
            if (instance == null)
                instance = new ValidationProjet();

            return instance;
        }

        public bool isNumeroProjetValide(string numeroProjet)
        {
            if (!string.IsNullOrEmpty(numeroProjet.Trim()))
                return true;
            else
                return false;
        }

        public bool isTitreValide(string titre)
        {
            if (!string.IsNullOrEmpty(titre.Trim()))
                return true;
            else
                return false;
        }

        public bool isDateDebutValide(string dateDebut)
        {
            if (!string.IsNullOrEmpty(dateDebut.Trim()))
                return true;
            else
                return false;
        }

        public bool isDescriptionValide(string description)
        {
            if (!string.IsNullOrEmpty(description.Trim()))
                return true;
            else
                return false;
        }

        public bool isBudgetValide(int index)
        {
            if (index >= 0)
                return true;
            else
                return false;
        }




        public bool isNbrEmployeValide(int index)
        {
            if (index >= 0)
                return true;
            else
                return false;
        }



        public bool isTotalSalValide(int index)
        {
            if (index >= 0)
                return true;
            else
                return false;
        }



        public bool isClientValide(int index)
        {
            if (index >= 0)
                return true;
            else
                return false;
        }


        public bool isStatutValide(string statut)
        {
            if (!string.IsNullOrEmpty(statut.Trim()))
                return true;
            else
                return false;
        }





    }
}
