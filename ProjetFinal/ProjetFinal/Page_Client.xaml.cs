using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using MySqlX.XDevAPI.Common;
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
    public sealed partial class Page_Client : Page
    {
        public Page_Client()
        {
            this.InitializeComponent();
        }



        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int valide = 0;

            if (tbxIdClient.Text.Trim() == "")
            {


                ErreurIdClient.Visibility = Visibility.Visible;
                valide += 1;

            }
            if (tbxNom.Text.Trim() == "")
            {


                ErreurNom.Visibility = Visibility.Visible;
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

            if (tbxTelephone.Text.Trim() == "")
            {


                ErreurTelephone.Visibility = Visibility.Visible;
                valide += 1;

            }


            if (valide == 0)
            {
                SingletonClient.getInstance().AjouterEmployer(tbxIdClient.Text, tbxNom.Text, tbxEmail.Text, tbxAdresse.Text, tbxTelephone.Text);
                formClient.Visibility = Visibility.Collapsed;
                validation.Visibility = Visibility.Visible;
            }



        }

    }
}
