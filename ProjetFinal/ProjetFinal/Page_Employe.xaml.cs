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
    public sealed partial class Page_Employe : Page
    {
        public Page_Employe()
        {
            this.InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int valide = 0;

            if (tbxMatriculeEmployé.Text.Trim() == "")
            {


                ErreurMatricule.Visibility = Visibility.Visible;
                valide += 1;

            }
            if (tbxNomEmployé.Text.Trim() == "")
            {


                ErreurEmployé.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxPrenomEmployé.Text.Trim() == "")
            {


                ErreurPrenom.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (tbxDateNaissance.Text.Trim() == "")
            {


                ErreurDateNaissance.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxEmail.Text.Trim() == "")
            {


                ErreurEmail.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxAdresse.Text.Trim() == "")
            {


                ErreurAdresse.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxDateEmbauche.Text.Trim() == "")
            {


                ErreurDateEmbauche.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxTauxHoraire.Text.Trim() == "")
            {


                ErreurTauxHoraire.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (tbxPhoto.Text.Trim() == "")
            {


                ErreurPhoto.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxStatut.Text.Trim() == "")
            {


                ErreurStatut.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (valide == 0)
            {
                SingletonEmploye.getInstance().AjouterEmployer(tbxMatriculeEmployé.Text, tbxNomEmployé.Text, tbxPrenomEmployé.Text, tbxDateNaissance.Text, tbxEmail.Text, tbxAdresse.Text, tbxDateEmbauche.Text, tbxTauxHoraire.Text, tbxPhoto.Text, tbxStatut.Text);
                formEmployé1.Visibility = Visibility.Collapsed;
                validation2.Visibility = Visibility.Visible;
            }



        }













    }
}
