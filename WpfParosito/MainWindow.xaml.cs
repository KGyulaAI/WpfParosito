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

namespace WpfParosito
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

        private void btnMix_Click(object sender, RoutedEventArgs e)
        {
            if (lbFiuk.Items.Count > 0 && lbLanyok.Items.Count > 0)
            {
                Random random = new Random();
                int randomFiuIndex = random.Next(0, lbFiuk.Items.Count - 1);
                int randomLanyIndex = random.Next(0, lbLanyok.Items.Count - 1);
                lbParok.Items.Add($"{lbFiuk.Items.GetItemAt(randomFiuIndex)} + {lbLanyok.Items.GetItemAt(randomLanyIndex)}");
                lbFiuk.Items.RemoveAt(randomFiuIndex);
                lbLanyok.Items.RemoveAt(randomLanyIndex);
            }
        }

        private void txtFiuNev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txtFiuNev.Text != "" && !txtFiuNev.Text.StartsWith(" ") && txtFiuNev.Text.Contains(" "))
            {
                lbFiuk.Items.Add(txtFiuNev.Text);
                txtFiuNev.Clear();
            }
        }

        private void txtLanyNev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txtLanyNev.Text != "" && !txtLanyNev.Text.StartsWith(" ") && txtLanyNev.Text.Contains(" "))
            {
                lbLanyok.Items.Add(txtLanyNev.Text);
                txtLanyNev.Clear();
            }
        }
    }
}
