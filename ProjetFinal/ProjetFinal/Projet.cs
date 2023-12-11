using ProjetFinal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace ProjetFinal
{
    internal class Projet
    {

        String numeroProjet;
        String titre;
        String dateDebut;
        String description;
        int budget;
        int nbrEmploye;
        double totalSal;
        int client;
        String statut;

    

        public Projet()
        {
            this.NumeroProjet= "";
            this.Titre = "";
            this.DateDebut = "";
            this.Description = "";
            this.Budget = 0;
            this.NbrEmploye = 0;
            this.TotalSal = 0;
            this.Client = 0;
            this.Statut = "";
        }

        public Projet(string _numeroProjet, string _titre, string _dateDebut, string _description, int _budget, int _nbrEmploye, double _totalSal, int _client, string _statut)
        {
            this.NumeroProjet = _numeroProjet;
            this.Titre = _titre;
            this.DateDebut = _dateDebut;
            this.Description = _description;
            this.Budget = _budget;
            this.NbrEmploye = _nbrEmploye;
            this.TotalSal = _totalSal;
            this.Client = _client;
            this.Statut = _statut;
        }


        public string NumeroProjet { get => numeroProjet; set => numeroProjet = value; }
        public string Titre { get => titre; set => titre = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string Description { get => description; set => description = value; }
        public int Budget { get => budget; set => budget = value; }
        public int NbrEmploye { get => nbrEmploye; set => nbrEmploye = value; }
        public double TotalSal { get => totalSal; set => totalSal = value; }
        public int Client{ get => client; set => client= value; }
        public string Statut { get => statut; set => statut = value; }



        public override string ToString()
        {
            return numeroProjet + " " + titre + " " + dateDebut + " " + description + " " + budget + " " + nbrEmploye + " " + totalSal + " " + client + " " + statut;
        }

    }

}






