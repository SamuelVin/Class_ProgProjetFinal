using Microsoft.WindowsAppSDK.Runtime.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class Utilisateur
    {

        String nomUtilisateur;
        String motdePasse;
        String type;

    
    public Utilisateur()
    {
        this.nomUtilisateur = "";
        this.motdePasse = "";
        this.type= "";
       
    }

        public Utilisateur( string _nomUtilisateur, string _motdePasse, string _type)
        {
            this.NomUtilisateur = _nomUtilisateur;
            this.MotdePasse = _motdePasse;
            this.Type = _type;
        }

        public string NomUtilisateur { get => NomUtilisateur; set => NomUtilisateur = value; }
        public string MotdePasse { get => motdePasse; set => motdePasse = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return NomUtilisateur + " " + motdePasse + " " + type ;
        }



    }
}