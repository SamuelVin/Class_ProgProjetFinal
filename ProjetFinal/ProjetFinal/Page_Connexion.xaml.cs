using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.WindowsAppSDK.Runtime.Packages;
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
    public sealed partial class Page_Connexion : Page
    {
        public Page_Connexion()
        {
            this.InitializeComponent();
            if (SingletonUtilisateur.getInstance().IsConnect() == true)
            {
                tblErreurPassword.Visibility = Visibility.Collapsed;
                tblErreurUsername.Visibility = Visibility.Collapsed;
                tbxPassword.Visibility = Visibility.Collapsed;
                tbxUsername.Visibility = Visibility.Collapsed;
                btConnecter.Visibility = Visibility.Collapsed;
                btAcces.Visibility = Visibility.Collapsed;
            }
        }


        private async void btConnecter_Click(object sender, RoutedEventArgs e)
        {
            bool valide = true;

            if (string.IsNullOrEmpty(tbxUsername.Text.Trim())) 
            {
                valide = false;
                tblErreurUsername.Text = "Veuillez entrer le nom d'utilisateur";
            }
            if (string.IsNullOrEmpty(tbxPassword.Password.Trim())) 
            {
                valide = false;
                tblErreurPassword.Text = "Veuillez entrer le mot de passe";
            }

            if (valide == false)
            {
                return;
            }

            SingletonUtilisateur.getInstance().UserConnect(tbxUsername.Text.Trim(), tbxPassword.Password.Trim());

            ContentDialog dialog = new ContentDialog();
            dialog.XamlRoot = mainGrid.XamlRoot;
            dialog.Title = "Connexion";
            dialog.PrimaryButtonText = "OK";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.Content = "L'utilisateur a été connecté avec succès";

            ContentDialogResult resultat = await dialog.ShowAsync();

            this.Frame.Navigate(typeof(Page_Projet));

        }

        private void btAcces_Click(object sender, RoutedEventArgs e)
        {
            SingletonUtilisateur.getInstance().ChangeConnect(true);
            this.Frame.Navigate(typeof(Page_Projet));
        }
        private void btDeconnecter_Click(object sender, RoutedEventArgs e)
        {
            SingletonUtilisateur.getInstance().ChangeConnect(false);
            this.Frame.Navigate(typeof(Page_Projet));
        }
    }
}
