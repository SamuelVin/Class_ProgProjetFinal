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
        Double totalSal;
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

    public Projet(string numeroProjet, string titre, string _dateDebut, string _description, int budget, int nbrEmploye, string employe, double totalSal, int client, string statut)
    {
        this.NumeroProjet = numeroProjet;
        this.Titre = titre;
        this.DateDebut = DateDebut;
        this.Description = description;
        this.Budget = budget;
        this.NbrEmploye = nbrEmploye;
        this.TotalSal = totalSal;
        this.Client = client;
        this.Statut = statut;
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
           return numeroProjet + " " + titre + " " + dateDebut.ToString() + " " + description + " " + budget + " " + nbrEmploye + " " + totalSal + " " + client + " " + statut;
}


}

}






