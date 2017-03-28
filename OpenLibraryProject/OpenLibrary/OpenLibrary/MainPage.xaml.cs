using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OpenLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void moreDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetailsPage));

        }

        private async void About_Click(object sender, RoutedEventArgs e)
        {
            var aboutMsg = new Windows.UI.Popups.MessageDialog("Created by \nPaddy Vaughan\nYan Liu\nMinsu Lee\nJoey Gilkie\n©2017");
            await aboutMsg.ShowAsync();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
