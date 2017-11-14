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

namespace Lab10T03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int leveys;
        int korkeus;
        int karmipuunleveys;

        int Aikkuna;
        int Alasi;
        int Piiri;
        int integeer;

        string virhe = "Syöte ei ole numero";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtBox1.Text, out integeer))
            {
                txtBlock5.Text = null;
                leveys = int.Parse(txtBox1.Text);
                if (int.TryParse(txtBox2.Text, out integeer))
                {
                    txtBlock6.Text = null;
                    korkeus = int.Parse(txtBox2.Text);
                    if (int.TryParse(txtBox3.Text, out integeer))
                    {
                        txtBlock7.Text = null;
                        karmipuunleveys = int.Parse(txtBox3.Text);
                        Aikkuna = (leveys * korkeus) / 10;
                        Alasi = (leveys - karmipuunleveys) * (korkeus - karmipuunleveys) / 10;
                        Piiri = (leveys + leveys + korkeus + korkeus) / 10;

                        txtBlock1.Text = Aikkuna.ToString() + "cm^2";
                        txtBlock2.Text = Alasi.ToString() + "cm^2";
                        txtBlock3.Text = Piiri.ToString() + "cm";

                        ikkuna.Height = korkeus / 10;
                        ikkuna.Width = leveys /10;
                        ikkuna.StrokeThickness = karmipuunleveys / 10;
                    }
                    else
                    {
                        txtBlock7.Text = virhe.ToString();
                    }
                }
                else
                {
                    txtBlock6.Text = virhe.ToString();
                }
            }
            else
            {
                txtBlock5.Text = virhe.ToString();
            }

        }
    }
}
