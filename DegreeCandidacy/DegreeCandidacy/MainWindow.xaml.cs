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

namespace DegreeCandidacy
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

        private void btbContinue_Click(object sender, RoutedEventArgs e)
        {
            string username;
            string password;
            username = txt4X4.Text;
            password = txtPassword.Text;

            if(username!="")
            {
                if (password != "")
                {
                    Window1 win1 = new Window1();
                    win1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid password.");
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid username.");
                txt4X4.Clear();
                txtPassword.Clear();
            }

        }
    }
}
