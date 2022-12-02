using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TFT_sale_tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CBAisling_Copy_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboHillockChoiceSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboHillockChoice.SelectedIndex == 2)
            {
                if(ComboHillockPercent.SelectedIndex == 0)
                {
                    ComboHillockPercent.SelectedIndex = 1;
                }
                //ComboHillockPercent.Items[4].IsEnabled = false
            }
            else
            {
                if(ComboHillockPercent != null)
                {
                    if (ComboHillockPercent.SelectedIndex == 1)
                    {
                        ComboHillockPercent.SelectedIndex = 0;
                    }
                }
                
                //ComboHillockPercent.Items[4].IsEnabled = false
            }
        }

        private void CBTujenCurrency_Copy1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Window1 set1 = new Window1();
            set1.Show();
        }

        private void btnCopyClipboard_Click(object sender, RoutedEventArgs e)
        {
            string resultText = System.Configuration.ConfigurationManager.AppSettings["baseText"] + "\n";
            if (tabMain.SelectedItem == tabBetrayal)
            {
                resultText += System.Configuration.ConfigurationManager.AppSettings["textBetrayal"] + "\n";
                if ((bool)CBAisling.IsChecked)
                {
                    resultText += "T4 Aisling " + TBAislingPrice.Text + " " + ComboCurrencyAisling.Text + "\n";
                }
                if ((bool)CBHillock.IsChecked)
                {
                    resultText += "Hillock " + ComboHillockChoice.Text + " " + ComboHillockPercent.Text + " " + TBHillockPrice.Text + " " + ComboCurrencyHillock.Text + "\n";
                }
            }
            else if (tabMain.SelectedItem == tabExpedition)
            {
                resultText += System.Configuration.ConfigurationManager.AppSettings["textExpedition"] + "\n";
            }
            else if (tabMain.SelectedItem == tabHeist)
            {
                resultText += System.Configuration.ConfigurationManager.AppSettings["textHeist"] + "\n";
            }
            resultText += "IGN: " + System.Configuration.ConfigurationManager.AppSettings["ign"];
            System.Windows.Clipboard.SetText(resultText);
        }
    }
}
