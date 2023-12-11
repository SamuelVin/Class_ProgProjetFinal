using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class SingletonClient
    {
        static SingletonProjet instance = null;
        MySqlConnection con;
        ObservableCollection<Client> listeClient;

        public SingletonClient()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420325ri_fabeq2; Uid=2260734; Pwd=2260734;");
            listeClient = new ObservableCollection<Client>();
        }

        public static SingletonProjet getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonProjet();
            }
            return instance;
        }
        public void AjouterClient(int idClient, string nom, string email, string adresse, string telephone)
        {

            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                /// commande.CommandText = "insert into clients values(10,'doe','john','mail@mail.com')";
                commande.CommandText = "insert into client values(@idClient,@nom,@email,@adresse,@telephone) ";

                //commande.Parameters.AddWithValue("@id", id);
                commande.Parameters.AddWithValue("@idClient", idClient);
                commande.Parameters.AddWithValue("@nom", nom);
                commande.Parameters.AddWithValue("@email", email);
                commande.Parameters.AddWithValue("@adresse", adresse);
                commande.Parameters.AddWithValue("@telephone", telephone);


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

        public ObservableCollection<Client> GetClients()
        {
            listeClient.Clear();
            try
            {

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "select * from employec";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    int idClient = (int)r["id_Client"];
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
    }
}


                    