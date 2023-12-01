using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class Employe
    {
        String matricule;
        String nom;
        String prenom;
        String dateNaissance;
        String email;
        String adresse;
        String dateEmbauche;
        String tauxHoraire;
        String photo;
        String statut;

        public Employe()
        {
            this.matricule = "";
            this.nom = "";
            this.prenom = "";
            this.dateNaissance = "";
            this.email = "";
            this.adresse = "";
            this.dateEmbauche = "";
            this.tauxHoraire= "";
            this.photo = "";
            this.statut= "";


        }

        public Employe(string _matricule, string _nom, string _prenom ,string _dateNaissance, string _email, string _adresse ,string _dateEmbauche, string _tauxHoraire, string _photo, string _statut)
        {
            this.Matricule = _matricule;
            this.Nom = _nom;
            this.Prenom = _prenom;

            this.DateNaissance = _dateNaissance;
            this.Email = _email;
            this.Adresse = _adresse;

            this.DateEmbauche = _dateEmbauche;
            this.TauxHoraire = _tauxHoraire;
            this.Photo = _photo;
            this.Statut = _statut;
        }

        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public string DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }


        public string DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public string TauxHoraire { get => tauxHoraire; set => tauxHoraire = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Statut { get => statut; set => statut = value; }

        public override string ToString()
        {
            return matricule + " " + nom + " " + prenom + dateNaissance + " " + email + adresse + " " + dateEmbauche + tauxHoraire + " " + photo + statut;
        
        
        }
    }
        }









    

