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
using CLKonto;

namespace WpfKonto
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Konto k = new Konto();
        

        public MainWindow()
        {
            InitializeComponent();
            tbName.Text = k.Name;
            tbKonto.Text = Convert.ToString(k.Kontostand);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbBetrag.Text != "")
                try
                {
                    if (k.Kontostand > Convert.ToDouble(tbUser.Text))
                    {
                        k.decrease(Convert.ToDouble(tbUser.Text));
                    }
                    else
                    {
                        MessageBox.Show("Keine Kredite!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Ungültige Werte");
                }
            tbKonto.Text = Convert.ToString(k.Kontostand);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   if (tbBetrag.Text != "")
            try
            {
                k.raise(Convert.ToDouble(tbBetrag.Text));
            }
            catch
            {
                MessageBox.Show("Ungültige Werte");
            }
            tbKonto.Text = Convert.ToString(k.Kontostand);
        }

        private void tbBetrag_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void tbBetrag_GotFocus(object sender, RoutedEventArgs e)
        {
            tbBetrag.Text = "";
        }

        private void tbUser_GotFocus(object sender, RoutedEventArgs e)
        {
            tbUser.Text = "";
        }
    }
}
