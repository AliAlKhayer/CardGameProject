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

namespace BlackJack
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

        private void btnShuffle_Click(object sender, RoutedEventArgs e)
        {
            Deck deck1 = new Deck();
            deck1.shuffle();
            for (int i = 0; i < 52; i++)
            {
                lstShuffle.Items.Add(deck1.Deal());
            }                  
        }
        private void btnDeal_Click(object sender, RoutedEventArgs e)
        {
            Deck deck1 = new Deck();
            deck1.shuffle();
            for (int i = 0; i < 2; i++)
            {
                lstPlayer.Items.Add(deck1.Deal());
            }
            for (int i = 3; i < 5; i++)
            {
                lstDealer.Items.Add(deck1.Deal());
            }
        }

        private void btnHitMe_Click(object sender, RoutedEventArgs e)
        {
            Deck deck1 = new Deck();
            deck1.shuffle();
            for (int i = 0; i < 1; i++)
            {
                lstPlayer.Items.Add(deck1.Deal());
            }
        }
    }
}
