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
using System.Numerics;
using System.Runtime.CompilerServices;
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
    public sealed partial class AjoutProjet : Page
    {
        public AjoutProjet()
        {
            this.InitializeComponent();
            

        }
        private async void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            resetErreurs();
            bool valide = true;


            if (ValidationProjet.getInstance().isNumeroProjetValide(tbxNumeroProjet.Text) == false)
            {
                tblErreurNumeroProjet.Text = "Veuillez entrer le numero du projet";
                valide = false;
            }


            if (ValidationProjet.getInstance().isTitreValide(tbxTitre.Text) == false)
            {
                tblErreurTitre.Text = "Veuillez entrer le titre du projet";
                valide = false;
            }

            if (ValidationProjet.getInstance().isDateDebutValide(tbxDateDebut.Text) == false)
            {
                tblErreurDateDebut.Text = "Veuillez entrer la date de debut du projet";
                valide = false;
            }



            if (ValidationProjet.getInstance().isDescriptionValide(tbxDescription.Text) == false)
            {
                tblErreurDescription.Text = "Veuillez entrer le numero du projet";
                valide = false;
            }



            if (ValidationProjet.getInstance().isBudgetValide(tbxBudget.Text) == false)
            {
                tblErreurBudget.Text = "Veuillez entrer le budget du projet";
                valide = false;
            }

            if (ValidationProjet.getInstance().isNbrEmployeValide(tbxNbrEmploye.Text) == false)
            {
                tblErreurNbrEmploye.Text = "Veuillez entrer le nombre d'employé sur un projet";
                valide = false;
            }



            if (ValidationProjet.getInstance().isTotalSalValide(tbxTotalSal.Text) == false)
            {
                tblErreurTotalSal.Text = "Veuillez entrer le salaire total d'un employé ";
                valide = false;
            }


            if (ValidationProjet.getInstance().isClientValide(tbxClient.Text) == false)
            {
                tblErreurClient.Text = "Veuillez entrer le client du projet";
                valide = false;
            }


            if (ValidationProjet.getInstance().isStatutValide(tbxStatut.Text) == false)
            {
                tblErreurStatut.Text = "Veuillez entrer le Statut du projet";
                valide = false;
            }


            if (valide == true)
            {
                Projet projet = new Projet
                {

                    NumeroProjet = tbxNumeroProjet.Text,
                    Titre = tbxTitre.Text,
                    DateDebut = tbxDateDebut.Text,
                    Description = tbxDescription.Text,
                    Budget = int.Parse(tbxBudget.Text),
                    NbrEmploye = int.Parse(tbxNbrEmploye.Text),
                    TotalSal = double.Parse(tbxTotalSal.Text),
                    Client = int.Parse(tbxClient.Text),
                    Statut = tbxStatut.Text,


                };

                SingletonProjet.getInstance().AddProjets(tbxNumeroProjet.Text, tbxTitre.Text, tbxDateDebut.Text, tbxDescription.Text, int.Parse(tbxBudget.Text), int.Parse(tbxNbrEmploye.Text), double.Parse(tbxTotalSal.Text), int.Parse(tbxClient.Text), tbxStatut.Text);

                ContentDialog dialog = new ContentDialog();
                dialog.XamlRoot = mainGrid.XamlRoot;
                dialog.Title = "Ajout d'un projet";
                dialog.PrimaryButtonText = "OK";
                dialog.DefaultButton = ContentDialogButton.Primary;
                dialog.Content = "Le projet a été ajouté avec succès";

                ContentDialogResult resultat = await dialog.ShowAsync();

                this.Frame.Navigate(typeof(Page_Projet));

            }

        }
        private void resetErreurs()
        {
            tblErreurNumeroProjet.Text = string.Empty;
            tblErreurTitre.Text = string.Empty;
            tblErreurDateDebut.Text = string.Empty;
            tblErreurDescription.Text = string.Empty;
            tblErreurBudget.Text = string.Empty;
            tblErreurNbrEmploye.Text = string.Empty;
            tblErreurTotalSal.Text = string.Empty;
            tblErreurClient.Text = string.Empty;
            tblErreurStatut.Text = string.Empty;
        }
    }
}