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

namespace MensageBox
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

        private void msgSimples_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensagem Simples");        
        }

        private void msgsTitulo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensagem Com Titulo", "Mensagem Com Titulo");
        }

        private void msgTituloBotoes_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respostaa = MessageBox.Show("Voce Deseja Encerrar a Aplicação ? ", "Encerramento", MessageBoxButton.YesNo);
            if (respostaa == MessageBoxResult.Yes);
            {
                Close();
            }
        }

        private void msgTituloBotoesIcone_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult respostaa = MessageBox.Show("Voce Deseja Avaliar Nossa Aplicação ? ", "Avaliar Sofware", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (respostaa == MessageBoxResult.No) ;
            {
                Close();
            }
            if (respostaa == MessageBoxResult.Cancel) ;
            {
                Close();
            }

        }
    }
}
