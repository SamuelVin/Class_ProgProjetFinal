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
    public sealed partial class ModificationEmploye : Page
    {
        public ModificationEmploye()
        {
            this.InitializeComponent();
        }

        private async void btModifier_Click(object sender, RoutedEventArgs e)
        {
            resetErreurs();
            bool valide = true;


            if (ValidationEmploye.getInstance().isMatriculeValide(tbxMatricule.Text) == false)
            {
                tblErreurMatricule.Text = "Veuillez entrer le matricule de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isDateNaissanceValide(tbxDateNaissance.Text) == false)
            {
                tblErreurDateNaissance.Text = "Veuillez entrer la date de naissance de l'employé";
                valide = false;
            }


            if (ValidationEmploye.getInstance().isDateEmbaucheValide(tbxDateEmbauche.Text) == false)
            {
                tblErreurDateEmbauche.Text = "Veuillez entrer la Date d'embauche de l'employé";
                valide = false;
            }


            if (valide == true)
            {
                Employe employe = new Employe
                {
                    Matricule = tbxMatricule.Text,
                    DateNaissance = tbxDateNaissance.Text,
                    DateEmbauche = tbxDateEmbauche.Text,
                   
                  
                    
                };

                SingletonEmploye.getInstance().UpdateEmploye(tbxMatricule.Text,tbxDateNaissance.Text, tbxDateEmbauche.Text);

                ContentDialog dialog = new ContentDialog();
                dialog.Title = "Modification de l'employé";
                dialog.PrimaryButtonText = "OK";
                dialog.DefaultButton = ContentDialogButton.Primary;
                dialog.Content = "L'employé a été modifié avec succès";

                ContentDialogResult resultat = await dialog.ShowAsync();

            }

        }
        private void resetErreurs()
        {
            tblErreurMatricule.Text = string.Empty;
            tblErreurDateNaissance.Text = string.Empty;
            tblErreurDateEmbauche.Text = string.Empty;
            
        }





































    }
}
