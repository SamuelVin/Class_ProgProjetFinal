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
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(typeof(Page_Projet));
            Bt_Mod.Visibility = Visibility.Collapsed;
        }

        private void navView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var item = (NavigationViewItem)args.SelectedItem;

            Bt_Add.Visibility = Visibility.Visible;
            switch (item.Name)
            {
                case "NavBut1":
                    mainFrame.Navigate(typeof(Page_Projet));
                    Bt_Mod.Visibility = Visibility.Collapsed;
                    break;
                case "NavBut2":
                    mainFrame.Navigate(typeof(Page_Client));
                    Bt_Mod.Visibility = Visibility.Collapsed;
                    break;
                case "NavBut3":
                    mainFrame.Navigate(typeof(Page_Employe));
                    Bt_Mod.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Bt_Add_Click(object sender, RoutedEventArgs e)
        {
            if (navView.SelectedItem is NavigationViewItem selectedItem)
            {
                if (SingletonUtilisateur.getInstance().IsConnect() == true)
                {
                    Bt_Add.Visibility = Visibility.Visible;
                    switch (selectedItem.Name)
                    {
                        case "NavBut1":
                            mainFrame.Navigate(typeof(AjoutProjet));
                            Bt_Mod.Visibility = Visibility.Collapsed;
                            break;
                        case "NavBut2":
                            mainFrame.Navigate(typeof(AjoutClient));
                            Bt_Mod.Visibility = Visibility.Collapsed;
                            break;
                        case "NavBut3":
                            mainFrame.Navigate(typeof(AjoutEmploye));
                            Bt_Mod.Visibility = Visibility.Visible;
                            break;
                    }
                }
            }
            else
            {
                mainFrame.Navigate(typeof(AjoutProjet));
            }
        }

        private void Bt_Mod_Click(object sender, RoutedEventArgs e)
        {
            if (navView.SelectedItem is NavigationViewItem selectedItem)
            {
                if (SingletonUtilisateur.getInstance().IsConnect() == true)
                {
                    Bt_Add.Visibility = Visibility.Visible;
                    switch (selectedItem.Name)
                    {
                        case "NavBut1":
                            mainFrame.Navigate(typeof(AjoutProjet));
                            Bt_Mod.Visibility = Visibility.Collapsed;
                            break;
                        case "NavBut2":
                            mainFrame.Navigate(typeof(AjoutClient));
                            Bt_Mod.Visibility = Visibility.Collapsed;
                            break;
                        case "NavBut3":
                            mainFrame.Navigate(typeof(ModificationEmploye));
                            Bt_Mod.Visibility = Visibility.Visible;
                            break;
                    }
                }
            }
            else
            {
                // Handle the case where no item is selected
            }
        }

        private void bt_User_Tapped(object sender, TappedRoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Page_Connexion));
            Bt_Add.Visibility = Visibility.Collapsed;
            Bt_Mod.Visibility = Visibility.Collapsed;
        }

        private void bt_Export_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}