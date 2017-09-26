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

namespace prova12_09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        double Normal = 100.00;
        double Luxo = 150.00;
        double Superluxo = 200.00;

        double Arcondicionado = 50.00;
        double Banheira = 40.00;
        double Wifi = 30.00;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            double valorTotal = 0;

            if (rbNormal.IsChecked == true)
            {
                valorTotal = valorTotal + Normal;

            }
            else if (rbLuxo.IsChecked == true)
            {
                valorTotal = valorTotal + Luxo;

            }
            else if (rbSuperluxo.IsChecked == true)
            {
                valorTotal = valorTotal + Superluxo;
               
            }
            if (cbArcondicionado.IsChecked == true)
            {
                valorTotal = valorTotal + Arcondicionado;
            }
            if (cbBanheira.IsChecked == true)
            {
                valorTotal = valorTotal + Banheira;
            }

            if (cbWifi.IsChecked == true)
            {
                valorTotal = valorTotal + Wifi;
            }

            double Valor = Convert.ToDouble(txtDias.Text);

            valorTotal = valorTotal * Valor;


            lbValor.Content = (valorTotal + " Reais");





            MessageBoxResult result = MessageBox.Show("Tem Certeza que deseja registrar o quarto com que foi selecionado?","Registro de quarto", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Registro de quarto realizado com sucesso!","Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
