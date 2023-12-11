using MySql.Data.MySqlClient;
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
        MySqlConnection con;
        ObservableCollection<Client> ListeClient;
        static SingletonClient singletonClient = null;


        public SingletonClient()
    {

        con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420325ri_fabeq2; Uid=2260734; Pwd=2260734;");
        listeClient = new ObservableCollection<Client>();
    }

        public static SingletonClient getInstance()
        {
            if (singletonClient == null)
                singletonClient = new SingletonClient();

            return singletonClient;
        }
        public void AjouterClient(int idClient, string nom, string email , string adresse , string telephone)
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

        public ObservableCollection<Employe> AffficheComboBox()
            {
                listeEmployes.Clear();
                try
                {

                    MySqlCommand commande = new MySqlCommand();
                    commande.Connection = con;
                    commande.CommandText = "select * from employec";

                    con.Open();
                    MySqlDataReader r = commande.ExecuteReader();

                    while (r.Read())
                    {

                        listeEmployes.Add(new Employe()
                        {
                            Matricule = r.GetString(0),
                            Nom = r.GetString(1),
                            Prenom = r.GetString(2),

                        });














                    }












    }






                    }

    }


                    