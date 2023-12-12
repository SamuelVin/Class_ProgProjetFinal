using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class ValidationClient
    {

        static ValidationClient instance;
        public ValidationClient() { }

    

    public static ValidationClient getInstance()
    {
        if (instance == null)
            instance = new ValidationClient();

        return instance;
    }  

        public bool isIdClientValide(string index)
    {
            try
            {

                double nbr4 = Convert.ToDouble(index);
                if (nbr4 >= 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    public bool isNomValide(string nom)
    {
        if (!string.IsNullOrEmpty(nom.Trim()))
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


        public bool isTelephoneValide(string telephone)
        {
            if (!string.IsNullOrEmpty(telephone.Trim()))
                return true;
            else
                return false;
        }


    }



}
