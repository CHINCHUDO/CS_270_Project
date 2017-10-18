using CS270_Ver_2._0.DataBases;
using CS270_Ver_2._0.Modules;
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

namespace CS270_Ver_2._0
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Aerial_Database.IntitializeMasterAerial();
            JhonFK_Database.InitializeJhonFK();
            PrintAerial();
        }

        public void PrintAerial()
        {
            var list = Aerial_Database.PrintAerial();
            foreach (TextBlock ibox in list)
            {
                Results.Items.Add(ibox);
            }
        }

        private void Results_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MailingResults.Items.Clear();
            var list = JhonFK_Database.PrintJhonFK(Aerial_Database.Aerial_Master[Results.SelectedIndex].CompanyName);
            foreach (TextBlock ibox in list)
            {
                MailingResults.Items.Add(ibox);
            }
        }
    }
}