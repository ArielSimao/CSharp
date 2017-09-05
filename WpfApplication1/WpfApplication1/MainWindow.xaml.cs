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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pessoa p = new Pessoa();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            p.nome = txtNome.Text;
            p.idade = int.Parse(txtIdade.Text);
            p.sexo = txtSexo.Text;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (p.isMaior().Equals(true))
            {
                MessageBox.Show(p.imprimeMaior());
            }
            else
            {
                MessageBox.Show(p.imprimeMenor());
            }
        }

        private void btnMasFem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnImparPar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMaiorMenor_Click(object sender, RoutedEventArgs e)
        {
            if (p.isMaior().Equals(true))
            {
                MessageBox.Show(p.imprimeMaior());
            }
            else
            {
                MessageBox.Show(p.imprimeMenor());
            }
        }

        private void txtSexo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
