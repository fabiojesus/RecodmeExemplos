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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Adicionamos ao click o evento que altera a primeira label para olá
            BTN.Click += (obj, e) => lbl1.Content = "Olá";
            //E agora adicionamos mais um evento para alterar a segunda label para tudo bem?
            BTN.Click += (obj, e) => lbl2.Content = "Tudo Bem?";
            //Vimos então que quando clicamos no botão, as duas labels são alteradas.
            //Naturalmente, este conteudo será abordado com maior detalhe no futuro.

        }

    }
}
