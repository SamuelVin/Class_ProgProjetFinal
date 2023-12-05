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
        DateTime dateDebut;
        String description;
        int budget;
        String nbrEmploye;
        String totalSal;
        String client;
        String statut;

    

    public Projet()
    {
        this.NumeroProjet= "";
        this.Titre = "";
        this.DateDebut = new DateTime();
        this.Description = "";
        this.Budget = 0;
        this.NbrEmploye = "";
        this.TotalSal = "";
        this.Client = "";
        this.Statut = "";
    }

    public Projet(string numeroProjet, string titre, int _adebut, int _moisdebut, int _jourdebut, string description, int budget, string nbrEmploye, string employe, string totalSal, string client, string statut)
    {
        this.NumeroProjet = numeroProjet;
        this.Titre = titre;
        this.DateDebut = new DateTime(_adebut, _moisdebut, _jourdebut);
        this.Description = description;
        this.Budget = budget;
        this.NbrEmploye = nbrEmploye;
        this.TotalSal = totalSal;
        this.Client = client;
        this.Statut = statut;
    }


    public string NumeroProjet { get => numeroProjet; set => numeroProjet = value; }
    public string Titre { get => titre; set => titre = value; }
    public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
    public string Description { get => description; set => description = value; }
    public int Budget { get => budget; set => budget = value; }
    public string NbrEmploye { get => nbrEmploye; set => nbrEmploye = value; }
    public string TotalSal { get => totalSal; set => totalSal = value; }
    public string Client{ get => client; set => client= value; }
    public string Statut { get => statut; set => statut = value; }



           public override string ToString()
        {
           return numeroProjet + " " + titre + " " + dateDebut.ToString() + " " + description + " " + budget + " " + nbrEmploye + " " + totalSal + " " + client + " " + statut;
}


}

}






