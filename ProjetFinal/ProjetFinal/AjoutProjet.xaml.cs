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
            calendar.MaxDate = new DateTimeOffset(new DateTime(2023, 12, 1));
            calendar.MinDate = new DateTimeOffset(new DateTime(2022, 12, 1));

        }


        private void btnvalider_Click(object sender, RoutedEventArgs e)
        {

            Double Budget = 0;
            DateTime d = new DateTime();
            int valide = 0;

            if (tbxNumeroProjet.Text.Trim() == "")
            {


                ErreurNumeroProjet.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxTitre.Text.Trim() == "")
            {


                ErreurTitre.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (tbxDescription.Text.Trim() == "")
            {


                ErreurDescription.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (tbxBudget.Text.Trim() == null)
            {


                ErreurBudget.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (tbxNbrEmploye.Text.Trim() == "")
            {


                ErreurNbrEmploye.Visibility = Visibility.Visible;
                valide += 1;
            }



            if (tbxNbrTotalSal.Text.Trim() == "")
            {


                ErreurNbrTotalSal.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxNbrClient.Text.Trim() == "")
            {


                ErreurNbrClient.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (tbxNbrStatut.Text.Trim() == "")
            {


                ErreurNbrStatut.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (liste.Text.Trim() == "")
            {
                ErreurEmployé.Visibility = Visibility.Visible;
            }

            try
            {
                budget = Double.Parse(tbxBudget.Text);
                if (budget < 10000 || budget > 100000)
                {
                    tbxBudget.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                ErreurBudget.Visibility = Visibility.Visible;
                valide++;
            }


            try
            {
                d = calendar.Date.Value.Date;
            }
            catch (InvalidOperationException ex)
            {
                ErreurCalendar.Visibility = Visibility.Visible;
                valide += 1;
            }


            if (valide == 0)
            {
                Employe emp = liste.SelectedItem as Employe;

                SingletonProjet.getInstance().AjouterProjet(tbxDescription.Text, tbxTitre.Text, tbxDescription.Text, budget, tbxNbrEmploye.Text, tbxNbrTotalSal.Text, tbxNbrClient.Text, tbxNbrStatut.Text, tbxNbrStatut.Text, d, emp.Matricule);
                formProjet.Visibility = Visibility.Collapsed;
                validation.Visibility = Visibility.Visible;
            }



        }





















    }
    }
