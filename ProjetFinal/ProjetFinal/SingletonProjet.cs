using Microsoft.WindowsAppSDK.Runtime.Packages;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class SingletonProjet
    {
        static SingletonProjet instance = null;
        MySqlConnection con;
        ObservableCollection<Projet> listeProjet;

        public SingletonProjet()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420325ri_fabeq2; Uid=2260734; Pwd=2260734;");
            listeProjet = new ObservableCollection<Projet>();
        }

        public static SingletonProjet getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonProjet();
            }
            return instance;
        }

        public ObservableCollection<Projet> GetProjet() 
        {  
            listeProjet.Clear();
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "SelectProjet";

                commande.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {        
                    string numeroProjet = (string)r["numero_projet"];
                    string titre = (string)r["titre"];
                    string dateDebut = (string)r["date_debut"];
                    string description = (string)r["description"];
                    int budget = (int)r["budget"];
                    int nbrEmploye = (int)r["nbr_employe"];
                    double totalSal = (double)r["total_salaire"];
                    int client = (int)r["client"];
                    string statut = (string)r["statut"];

                    Projet objProjet = new Projet { NumeroProjet = numeroProjet, Titre = titre, DateDebut = dateDebut, Description = description, Budget = budget, NbrEmploye = nbrEmploye, TotalSal = totalSal, Client = client, Statut = statut};
                    listeProjet.Add(objProjet);
                }

                r.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                if(con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listeProjet;
        }

        public void AddProjets(string numeroProjet, string titre, string dateDebut, string description, int budget, int nbrEmploye, double totalSal, int client, string statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand("AddProjet");
                commande.Connection = con;
                commande.CommandType = System.Data.CommandType.StoredProcedure;

                commande.Parameters.AddWithValue("@pnumeroProjet", numeroProjet);
                commande.Parameters.AddWithValue("@ptitre", titre);
                commande.Parameters.AddWithValue("@pdateDebut", dateDebut);
                commande.Parameters.AddWithValue("@pdescription", description);
                commande.Parameters.AddWithValue("@pbudget", budget);
                commande.Parameters.AddWithValue("@pnbrEmploye", nbrEmploye);
                commande.Parameters.AddWithValue("@ptotalSal", totalSal);
                commande.Parameters.AddWithValue("@pclient", client);
                commande.Parameters.AddWithValue("@pstatut", statut);

                con.Open();
                
                commande.Prepare();
                int i = commande.ExecuteNonQuery();

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

        public void UpdateProjets(string numeroProjet, string titre, string dateDebut, string description, int budget, int nbrEmploye, double totalSal, int client, string statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "UpdateProjet";

                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                commande.Parameters.AddWithValue("@pnumeroProjet", numeroProjet);
                commande.Parameters.AddWithValue("@ptitre", titre);
                commande.Parameters.AddWithValue("@pdateDebut", dateDebut);
                commande.Parameters.AddWithValue("@pdescription", description);
                commande.Parameters.AddWithValue("@pbudget", budget);
                commande.Parameters.AddWithValue("@pnbrEmploye", nbrEmploye);
                commande.Parameters.AddWithValue("@ptotalSal", totalSal);
                commande.Parameters.AddWithValue("@pclient", client);
                commande.Parameters.AddWithValue("@pstatut", statut);

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
