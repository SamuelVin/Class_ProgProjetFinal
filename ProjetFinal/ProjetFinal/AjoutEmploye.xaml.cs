using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ProjetFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AjoutEmploye : Page
    {
        public AjoutEmploye()
        {
            this.InitializeComponent();
        }

        private async void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            resetErreurs();
            bool valide = true;


            if (ValidationEmploye.getInstance().isMatriculeValide(tbxMatricule.Text) == false)
            {
                tblErreurMatricule.Text = "Veuillez entrer le matricule de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isNomValide(tbxNom.Text) == false)
            {
                tblErreurNom.Text = "Veuillez entrer le nom de l'employé";
                valide = false;
            }



            if (ValidationEmploye.getInstance().isPrenomValide(tbxPrenom.Text) == false)
            {
                tblErreurPrenom.Text = "Veuillez entrer le prenom de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isDateNaissanceValide(tbxDateNaissance.Text) == false)
            {
                tblErreurDateNaissance.Text = "Veuillez entrer la date de naissance de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isEmailValide(tbxEmail.Text) == false)
            {
                tblErreurEmail.Text = "Veuillez entrer l'email de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isAdresseValide(tbxAdresse.Text) == false)
            {
                tblErreurAdresse.Text = "Veuillez entrer l'adresse de l'employé";
                valide = false;
            }




            if (ValidationEmploye.getInstance().isDateEmbaucheValide(tbxDateEmbauche.Text) == false)
            {
                tblErreurDateEmbauche.Text = "Veuillez entrer la Date d'embauche de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isTauxHoraireValide(tbxTauxHoraire.Text) == false)
            {
                tblErreurTauxHoraire.Text = "Veuillez entrer le Taux horaire de l'employé";
                valide = false;
            }



            if (ValidationEmploye.getInstance().isPhotoValide(tbxPhoto.Text) == false)
            {
                tblErreurPhoto.Text = "Veuillez entrer la Photo de l'employé";
                valide = false;
            }



            if (ValidationEmploye.getInstance().isStatutValide(tbxStatut.Text) == false)
            {
                tblErreurStatut.Text = "Veuillez entrer le statut de l'employé";
                valide = false;
            }



            if (valide == true)
            {
                Employe employe = new Employe
                {
                    Matricule = tbxMatricule.Text,
                    Nom = tbxNom.Text,
                    Prenom = tbxPrenom.Text,
                    DateNaissance = tbxDateNaissance.Text,
                    Email = tbxEmail.Text,
                    Adresse = tbxAdresse.Text,
                    DateEmbauche = tbxDateEmbauche.Text,
                    TauxHoraire =double.Parse( tbxDateEmbauche.Text),
                    Photo = tbxPhoto.Text,
                    Statut = tbxStatut.Text,
                };

                SingletonEmploye.getInstance().AddEmploye(tbxMatricule.Text, tbxNom.Text, tbxPrenom.Text, tbxDateNaissance.Text, tbxEmail.Text, tbxAdresse.Text, tbxDateEmbauche.Text, double.Parse(tbxDateEmbauche.Text), tbxPhoto.Text, tbxStatut.Text);

                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Ajout de l'employé";
                dialog.PrimaryButtonText = "OK";
                dialog.DefaultButton = ContentDialogButton.Primary;
                dialog.Content = "L'employé a été ajouté avec succès";

                ContentDialogResult resultat = await dialog.ShowAsync();

            }

        }
        private void resetErreurs()
        {
            tblErreurMatricule.Text = string.Empty;
            tblErreurNom.Text = string.Empty;
            tblErreurPrenom.Text = string.Empty;
            tblErreurDateNaissance.Text = string.Empty;
            tblErreurEmail.Text = string.Empty;
            tblErreurAdresse.Text = string.Empty;
            tblErreurDateEmbauche.Text = string.Empty;
            tbxTauxHoraire.Text = string.Empty;
            tblErreurPhoto.Text = string.Empty;
            tblErreurStatut.Text = string.Empty;
        }



    }
    
}
