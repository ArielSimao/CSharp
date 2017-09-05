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
        Funcionario f = new Funcionario();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            f.nome = txtNome.Text;
            f.qtdHoras = int.Parse(txtHora.Text);
            f.valorHora = int.Parse(txtVhora.Text);
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            f.calcular();
            txtSalario.Text = Convert.ToString(f.salario);
            
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Clear();
            txtHora.Clear();
            txtVhora.Clear();
            txtSalario.Clear();
        }
    }
}
