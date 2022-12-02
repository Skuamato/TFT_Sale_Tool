using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TFT_sale_tool
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            textBaseText.Text = System.Configuration.ConfigurationManager.AppSettings["baseText"];
            textIGN.Text = System.Configuration.ConfigurationManager.AppSettings["ign"];
            textBetrayal.Text = System.Configuration.ConfigurationManager.AppSettings["textBetrayal"];
            textExpedition.Text = System.Configuration.ConfigurationManager.AppSettings["textExpedition"];
            textHeist.Text = System.Configuration.ConfigurationManager.AppSettings["textExpedition"];
        }

        private void btnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            System.Configuration.ConfigurationManager.AppSettings["baseText"] = textBaseText.Text;
            System.Configuration.ConfigurationManager.AppSettings["ign"] = textIGN.Text;
            System.Configuration.ConfigurationManager.AppSettings["textBetrayal"] = textBetrayal.Text;
            System.Configuration.ConfigurationManager.AppSettings["textExpedition"] = textExpedition.Text;
            System.Configuration.ConfigurationManager.AppSettings["textExpedition"] = textHeist.Text;
            this.Close();
        }

        private void btnDiscardChanges_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textBaseText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
