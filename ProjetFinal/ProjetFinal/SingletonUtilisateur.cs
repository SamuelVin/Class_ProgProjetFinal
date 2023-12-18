using Microsoft.WindowsAppSDK.Runtime.Packages;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class SingletonUtilisateur
    {

        static SingletonUtilisateur instance = null;
        MySqlConnection con;
        ObservableCollection<Utilisateur> listeUtilisateur;

        public SingletonUtilisateur()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420325ri_fabeq2; Uid=2260734; Pwd=2260734;");
            listeUtilisateur = new ObservableCollection<Utilisateur>();
        }

        public static SingletonUtilisateur getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonUtilisateur();
            }
            return instance;
        }

        public bool ReturnConnected(string Utilisateur, string Password)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "UtilisateurConnect";
                commande.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                commande.Parameters.AddWithValue("@pUsername", Utilisateur);
                commande.Parameters.AddWithValue("@pPassword", Password);

                con.Open();

                // Execute the stored procedure
                object result = commande.ExecuteScalar();

                con.Close();

                // Check the result of the stored procedure
                if (result != null && result is bool)
                {
                    return (bool)result;
                }
                else
                {
                    // Handle the case where the result is not as expected
                    // You may want to log an error or throw an exception
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                // You may want to log an error or throw an exception
                return false;
            }
        }

    }
}
