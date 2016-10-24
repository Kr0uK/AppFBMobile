using System;
using System.Runtime;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{

 
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Ici on met l'URL qu'on veut
        String url = "https://m.facebook.com/notifications/";

        public MainPage()
        {
            this.InitializeComponent();
        }

     

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {

            // On recharge l'URL quand on clique sur Rafraichir + Exception
            try
            {
                Uri targetUri = new Uri(url);
                ViewPage.Navigate(targetUri);
            }
            catch (Exception EE)
            {
                
                ViewPage.NavigateToString(String.Format("Addresse invalide, veuillez réessayer.>"));
            }


        }

        private void ViewPage_Loaded(object sender, RoutedEventArgs e)
        {

            //On charge l'URL au chargement du WebView
            try
            {
                Uri targetUri = new Uri(url);
                ViewPage.Navigate(targetUri);
            }
            catch (Exception EE)
            {
               
                ViewPage.NavigateToString(String.Format("Addresse invalide, veuillez réessayer.>"));
            }
        }

        private void messenger_Click(object sender, RoutedEventArgs e)
        {
            // TODO

            


        }

        private void ViewPage_LoadCompleted(object sender, NavigationEventArgs e)
        {
            // TODO
        }
    }
}
