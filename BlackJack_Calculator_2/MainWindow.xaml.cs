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

namespace BlackJack_Calculator_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblHLR.Content = "0";
        }
        BlackJack black = new BlackJack();

        public void HighLow(int input)
        {
            int numero = Convert.ToInt32(lblHLR.Content);
            lblHLR.Content= black.HighLow(numero,input);
        }

        public void BotonPlayer1(int numero)
        {
            black.AgregarCartaPlayer1(numero);
            int cuenta = black.CalcularPlayer1();
            lblCuentaPlayer.Content = cuenta;
            HighLow(numero);
            lblProbBlackjackR.Content = black.BlackJackPlayer() + "%";
        }

        public void BotonPlayer2(int numero)
        {
            black.AgregarCartaPlayer2(numero);
            lblCuentaPlayer2.Content = black.CalcularPlayer2();
            HighLow(numero);
            lblProbBlackjackR.Content = black.BlackJackPlayer() + "%";
        }

        public void BotonDealer(int numero)
        {
            black.AgregarCartaDealer(numero);
            lblCuentaDealer.Content = black.CalcularDealer();
            HighLow(numero);
            lblProbBlackjackR.Content = black.BlackJackPlayer() + "%";
            int cuenta = black.CalcularDealer();
            lblprobDealer21.Content = black.probCantidad(cuenta, 21) + "%";
        }

        public void ActAs()
        {
            lblAsR.Content = black.ActualizarRestantes(11);
        }

        public void Act2()
        {
            lbl2R.Content = black.ActualizarRestantes(2);
        }

        public void Act3()
        {
            lbl3R.Content = black.ActualizarRestantes(3);
        }

        public void Act4()
        {
            lbl4R.Content = black.ActualizarRestantes(4);
        }

        public void Act5()
        {
            lbl5R.Content = black.ActualizarRestantes(5);
        }

        public void Act6()
        {
            lbl6R.Content = black.ActualizarRestantes(6);
        }

        public void Act7()
        {
            lbl7R.Content = black.ActualizarRestantes(7);
        }

        public void Act8()
        {
            lbl8R.Content = black.ActualizarRestantes(8);
        }

        public void Act9()
        {
            lbl9R.Content = black.ActualizarRestantes(9);
        }

        public void Act10()
        {
            lbl10R.Content = black.ActualizarRestantes(10);
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            black.Limpiar();
            int NumMazos = Convert.ToInt32(txtNumMazos.Text);
            black.ConstruirMazo(NumMazos);
            lblProbBlackjackR.Content=black.BlackJackPlayer()+"%";
            lblprobDealer21.Content = black.probCantidad(0, 21) * 100 + "%";

            lblAsR.Content = 4*NumMazos;
            lbl2R.Content = 4*NumMazos;
            lbl3R.Content = 4 * NumMazos;
            lbl4R.Content = 4 * NumMazos;
            lbl5R.Content= 4 * NumMazos;
            lbl6R.Content= 4 * NumMazos;
            lbl7R.Content= 4 * NumMazos;
            lbl8R.Content= 4 * NumMazos;
            lbl9R.Content= 4 * NumMazos;
            lbl10R.Content = 16 * NumMazos;
        }

        public void BtnDealerAs_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(11);
            ActAs();
        }

        private void BtnDealer2_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(2);
        }

        private void BtnDealer3_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(3);
        }

        private void BtnDealer4_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(4);
        }

        private void BtnDealer5_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(5);
        }

        private void BtnDealer6_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(6);
        }

        private void BtnDealer7_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(7);
        }

        private void BtnDealer8_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(8);
        }

        private void BtnDealer9_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(9);
        }

        private void BtnDealer10_Click(object sender, RoutedEventArgs e)
        {
            BotonDealer(10);
        }

        private void BtnPlayerAs_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(11);
            ActAs();
        }

        private void BtnPlayer2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(2);
        }

        private void BtnPlayer3_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(3);
        }

        private void BtnPlayer4_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(4);
        }

        private void BtnPlayer5_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(5);
        }

        private void BtnPlayer6_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(6);
        }

        private void BtnPlayer7_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(7);
        }

        private void BtnPlayer8_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(8);
        }

        private void BtnPlayer9_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(9);
        }

        private void BtnPlayer10_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer1(10);
        }

        private void BtnPlayerAs_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(11);
            ActAs();
        }

        private void BtnPlayer2_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(2);
        }

        private void BtnPlayer3_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(3);
        }

        private void BtnPlayer4_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(4);
        }

        private void BtnPlayer5_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(5);
        }

        private void BtnPlayer6_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(6);
        }

        private void BtnPlayer7_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(7);
        }

        private void BtnPlayer8_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(8);
        }

        private void BtnPlayer9_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(9);
        }

        private void BtnPlayer10_2_Click(object sender, RoutedEventArgs e)
        {
            BotonPlayer2(10);
        }

        private void BtnSplit_Click(object sender, RoutedEventArgs e)
        {
            if (black.RevisarIguales()==true)
            {
                black.Split();
                lblCuentaPlayer.Content = black.CalcularPlayer1();
                lblCuentaPlayer2.Content = black.CalcularPlayer2();
            }
            else
            {
                MessageBox.Show("No es posible hacer split con mas de dos cartas o cuando estas son diferentes");
            }
        }

        private void BtnRonda_Click(object sender, RoutedEventArgs e)
        {
            black.Ronda();
            lblCuentaDealer.Content = "";
            lblCuentaPlayer.Content = "";
            lblCuentaPlayer2.Content = "";
        }
    }
}