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
using Windows.Media.Protection.PlayReady;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ProjetFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AjoutClient : Page
    {
        public AjoutClient()
        {
            this.InitializeComponent();
        }

        private async void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            resetErreurs();
            bool valide = true;


            if (ValidationClient.getInstance().isIdClientValide(tbxIdClient.Text)== false)
            {
                tblErreurIdClient.Text = "Veuillez entrer l'id du client";
                valide = false;
            }


            if (ValidationClient.getInstance().isNomValide(tbxNom.Text) == false)
            {
                tblErreurNom.Text = "Veuillez entrer le nom du client";
                valide = false;
            }


            if (ValidationClient.getInstance().isEmailValide(tbxEmail.Text) == false)
            {
                tblErreurEmail.Text = "Veuillez entrer l'Email du client";
                valide = false;
            }


            if (ValidationClient.getInstance().isAdresseValide(tbxAdresse.Text) == false)
            {
                tblErreurAdresse.Text = "Veuillez entrer l'Adresse du client";
                valide = false;
            }


            if (ValidationClient.getInstance().isTelephoneValide(tbxTelephone.Text) == false)
            {
                tblErreurTelephone.Text = "Veuillez entrer l'id du client";
                valide = false;
            }

            if (valide == true)
            {
                Client client = new Client
                {
                    IdClient = int.Parse(tbxIdClient.Text) ,
                    Nom = tbxNom.Text,
                    Email = tbxEmail.Text,
                    Adresse = tbxAdresse.Text,
                    Telephone = tbxTelephone.Text,
                };

                SingletonClient.getInstance().AddClients(int.Parse(tbxIdClient.Text), tbxNom.Text,  tbxEmail.Text,  tbxAdresse.Text,  tbxTelephone.Text);

                ContentDialog dialog = new ContentDialog();
                dialog.XamlRoot = mainGrid.XamlRoot;
                dialog.Title = "Ajout du client";
                dialog.PrimaryButtonText = "OK";
                dialog.DefaultButton = ContentDialogButton.Primary;
                dialog.Content = "Le client a été ajouté avec succès";

                ContentDialogResult resultat = await dialog.ShowAsync();

                this.Frame.Navigate(typeof(Page_Projet));
            }

        }
        private void resetErreurs()
        {
            tblErreurIdClient.Text = string.Empty;
            tblErreurNom.Text = string.Empty;
            tblErreurEmail.Text = string.Empty;
            tblErreurAdresse.Text = string.Empty;
            tblErreurTelephone.Text = string.Empty;
        }


    }

}
