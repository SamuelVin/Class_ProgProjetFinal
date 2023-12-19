using Microsoft.WindowsAppSDK.Runtime.Packages;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
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

        Boolean IsConnected = false;

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

        public void ChangeConnect(Boolean newBool)
        {
            IsConnected = newBool;
        }
        public bool IsConnect()
        { 
            return IsConnected; 
        }
        public void UserConnect(string utilisateur, string password)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("UtilisateurConnect");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("@pUsername", utilisateur);
                commande.Parameters.AddWithValue("@pPassword", password);

                con.Open();

                // Execute the stored procedure
                object result = commande.ExecuteScalar();

                con.Close();

                // Check the result of the stored procedure
                if (result != null && result is bool)
                {
                    IsConnected = (bool)result;
                }
                else
                {
                    // Handle the case where the result is unexpected or null
                    IsConnected = false;
                }

            }
            catch (MySqlException ex)
            {
                IsConnected = false;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                IsConnected = false;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
}
