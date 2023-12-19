using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class ValidationEmploye

    {

        static ValidationEmploye instance;
        public ValidationEmploye() { }


        public static ValidationEmploye getInstance()
        {
            if (instance == null)
                instance = new ValidationEmploye();

            return instance;
        }


        public bool isMatriculeValide(string matricule)
        {
            if (!string.IsNullOrEmpty(matricule.Trim()))
                return true;
            else
                return false;
        }
        public bool isNomValide(string nom)
        {
            if (!string.IsNullOrEmpty(nom.Trim()))
                return true;
            else
                return false;
        }
        public bool isPrenomValide(string prenom)
        {
            if (!string.IsNullOrEmpty(prenom.Trim()))
                return true;
            else
                return false;
        }
        public bool isDateNaissanceValide(string dateNaissance)
        {
            if (!string.IsNullOrEmpty(dateNaissance.Trim()))
                return true;
            else
                return false;
        }
        public bool isEmailValide(string email)
        {
            if (!string.IsNullOrEmpty(email.Trim()))
                return true;
            else
                return false;
        }
        public bool isAdresseValide(string adresse)
        {
            if (!string.IsNullOrEmpty(adresse.Trim()))
                return true;
            else
                return false;
        }
        public bool isDateEmbaucheValide(string dateEmbauche)
        {
            if (!string.IsNullOrEmpty(dateEmbauche.Trim()))
                return true;
            else
                return false;
        }

        public bool isTauxHoraireValide(string index)
        {
            try
            {
                double nbr2 = Convert.ToDouble(index);
               
                if (nbr2 >= 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool isPhotoValide(string photo)
        {
            if (!string.IsNullOrEmpty(photo.Trim()))
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
