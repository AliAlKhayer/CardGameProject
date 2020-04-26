﻿using System;
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
            lstShuffle.Items.Add(deck1);

            
            
        }

        private void btnDeal_Click(object sender, RoutedEventArgs e)
        {
            Deck deck1 = new Deck();
            deck1.Deal();
            lstDeal.Items.Add(deck1);
        }
    }
}
