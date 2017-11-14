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

namespace Lab10T02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number;
        double number2;

        int integeeri;
        string stringuliini;
        string usd = "Yhdysvallat USD";
        string eur = "Suomi EUR";
        string kirjain = "Syötä numeroita";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void dropBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
                ListBoxItem listitem = (ListBoxItem)dropBox1.SelectedItem;
                if ((ListBoxItem)dropBox1.SelectedItem == usd1)
                {
                    txtBlock3.Text = eur.ToString();
                }
                else if ((ListBoxItem)dropBox1.SelectedItem == eur1)
                {
                    txtBlock3.Text = usd.ToString();
                }
                else
                {
                    txtBlock3.Text = "Kohde valuutta";
                }
                
            
        }
        private void txtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                    if (int.TryParse(txtBox1.Text, out integeeri))
                    {
                    txtBlock1.Text = null;
                        if ((ListBoxItem)dropBox1.SelectedItem == usd1)
                        {
                            number = double.Parse(txtBox1.Text);
                            number2 = number * 0.8498; //googlesta
                            txtBox2.Text = number2.ToString("0.00");
                        }
                        else if ((ListBoxItem)dropBox1.SelectedItem == eur1)
                        {
                            number = double.Parse(txtBox1.Text);
                            number2 = number * 1.1766; //googlesta
                            txtBox2.Text = number2.ToString("0.00");
                        }
                    }
                    else
                    {
                        txtBlock1.Text = kirjain.ToString();
                    }
                
            }
            catch (Exception ex)
            {
                txtBlock4.Text = ex.Message;   
            }

        }
    }
}
