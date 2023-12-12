using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    internal class Client
    {

       int idClient;
       String nom;
       String email;
       String adresse;
       String telephone;


        public Client()
        {
            this.IdClient = 0;
            this.Nom = "";
            this.Email = "";
            this.Adresse = "";
            this.Telephone = "";
        }

        public Client(int _idClient, string _nom, string _email, string _adresse, string _telephone)
        {
            this.IdClient = _idClient;
            this.Nom = _nom;
            this.Email = _email;
            this.Adresse = _adresse;
            this.Telephone = _telephone;
        }

        public int IdClient { get => idClient; set => idClient = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Email { get => email; set =>email = value; }
        public string Adresse{ get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }



        public override string ToString()
        {
            return idClient + " " + nom + " " + email + " " + adresse + " " + telephone;
        }



    }
}
