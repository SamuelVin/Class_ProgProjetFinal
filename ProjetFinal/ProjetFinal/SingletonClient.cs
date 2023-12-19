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
    internal class SingletonClient
    {
        static SingletonClient instance = null;
        MySqlConnection con;
        ObservableCollection<Client> listeClient;

        public SingletonClient()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420325ri_fabeq2; Uid=2260734; Pwd=2260734;");
            listeClient = new ObservableCollection<Client>();
        }

        public static SingletonClient getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonClient();
            }
            return instance;
        }

        public ObservableCollection<Client> GetClients()
        {
            listeClient.Clear();
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SelectClient";

                commande.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    int idClient = (int)r["id_client"];
                    string nom = (string)r["nom"];
                    string email = (string)r["email"];
                    string adresse = (string)r["adresse"];
                    string telephone = (string)r["telephone"];

                    Client objClient = new Client { IdClient = idClient, Nom = nom, Email = email, Adresse = adresse, Telephone = telephone };
                    listeClient.Add(objClient);
                }
                r.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listeClient;
        }

        public void AddClients(int idClient, string nom, string email, string adresse, string telephone)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "AddClient";
                commande.CommandType = CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("@pId", idClient);
                commande.Parameters.AddWithValue("@pNom", nom);
                commande.Parameters.AddWithValue("@pEmail", email);
                commande.Parameters.AddWithValue("@pAdresse", adresse);
                commande.Parameters.AddWithValue("@pTelephone", telephone);

                con.Open();

                commande.Prepare();
                int i = commande.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                con.Close();
            }
        }

        public void UpdateProjets(int idClient, string nom, string email, string adresse, string telephone)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "UpdateClient";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                commande.Parameters.AddWithValue("@idClient", idClient);
                commande.Parameters.AddWithValue("@nom", nom);
                commande.Parameters.AddWithValue("@email", email);
                commande.Parameters.AddWithValue("@adresse", adresse);
                commande.Parameters.AddWithValue("@telephone", telephone);

                r.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
}


                    