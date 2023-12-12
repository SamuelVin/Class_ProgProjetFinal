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
    internal class SingletonEmploye
    {
        static SingletonEmploye instance = null;
        MySqlConnection con;
        ObservableCollection<Projet> listeProjet;

        public SingletonEmploye()
        {
            con = new MySqlConnection("Server=cours.cegep3r.info; Database=a2023_420325ri_fabeq2; Uid=2260734; Pwd=2260734;");
            listeProjet = new ObservableCollection<Projet>();
        }

        public static SingletonEmploye getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonEmploye();
            }
            return instance;
        }

        public ObservableCollection<Employe> GetEmploye()
        {
            ObservableCollection<Employe> listeEmploye = new ObservableCollection<Employe>();
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.CommandText = "SelectEmploye";
                command.CommandType = CommandType.StoredProcedure;

                con.Open();
                MySqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    string matricule = (string)r["matricule"];
                    string nom = (string)r["nom"];
                    string prenom = (string)r["prenom"];
                    string dateNaissance = (string)r["date_naissance"];
                    string email = (string)r["email"];
                    string adresse = (string)r["adresse"];
                    string dateEmbauche = (string)r["date_embauche"];
                    double tauxHoraire = (double)r["taux_horaire"];
                    string photo = (string)r["photo"];
                    string statut = (string)r["statut"];

                    Employe objEmploye = new Employe { Matricule = matricule, Nom = nom, Prenom = prenom, DateNaissance = dateNaissance, Email = email, Adresse = adresse, DateEmbauche = dateEmbauche, TauxHoraire = tauxHoraire, Photo = photo, Statut = statut };
                    listeEmploye.Add(objEmploye);
                }

                r.Close();
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listeEmploye;
        }

        public void AddEmploye(string matricule, string nom, string prenom, string dateNaissance, string email, string adresse, string dateEmbauche, double tauxHoraire, string photo, string statut)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.CommandText = "AddEmploye";
                command.CommandType = CommandType.StoredProcedure;

                con.Open();
                command.ExecuteNonQuery();

                command.Parameters.AddWithValue("@pmatricule", matricule);
                command.Parameters.AddWithValue("@pnom", nom);
                command.Parameters.AddWithValue("@pprenom", prenom);
                command.Parameters.AddWithValue("@pdateNaissance", dateNaissance);
                command.Parameters.AddWithValue("@pemail", email);
                command.Parameters.AddWithValue("@padresse", adresse);
                command.Parameters.AddWithValue("@pdateEmbauche", dateEmbauche);
                command.Parameters.AddWithValue("@ptauxHoraire", tauxHoraire);
                command.Parameters.AddWithValue("@pphoto", photo);
                command.Parameters.AddWithValue("@pstatut", statut);
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void UpdateEmploye(string matricule, string nom, string prenom, string dateNaissance, string email, string adresse, string dateEmbauche, double tauxHoraire, string photo, string statut)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = con;
                command.CommandText = "UpdateEmploye";
                command.CommandType = CommandType.StoredProcedure;

                con.Open();
                command.ExecuteNonQuery();

                command.Parameters.AddWithValue("@pmatricule", matricule);
                command.Parameters.AddWithValue("@pnom", nom);
                command.Parameters.AddWithValue("@pprenom", prenom);
                command.Parameters.AddWithValue("@pdateNaissance", dateNaissance);
                command.Parameters.AddWithValue("@pemail", email);
                command.Parameters.AddWithValue("@padresse", adresse);
                command.Parameters.AddWithValue("@pdateEmbauche", dateEmbauche);
                command.Parameters.AddWithValue("@ptauxHoraire", tauxHoraire);
                command.Parameters.AddWithValue("@pphoto", photo);
                command.Parameters.AddWithValue("@pstatut", statut);
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
