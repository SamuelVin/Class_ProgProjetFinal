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
                commande.CommandText = "Select * from projet";

                con.Open();

                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {        
                    string numeroProjet = (string)r["numero_projet"];
                    string titre = (string)r["titre"];
                    DateTime dateDebut = (DateTime)r["date_debut"];
                    string description = (string)r["description"];
                    int budget = (int)r["budget"];
                    string nbrEmploye = (string)r["nbr_employe"];
                    string totalSal = (string)r["total_salaire"];
                    string client = (string)r["client"];
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


    }
}
