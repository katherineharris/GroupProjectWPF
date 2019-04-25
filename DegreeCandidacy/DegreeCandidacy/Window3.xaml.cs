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
using System.Windows.Shapes;

namespace DegreeCandidacy
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            comboSelection.Items.Add("Accounting");
            comboSelection.Items.Add("Finance");
            comboSelection.Items.Add("Marketing");
            comboSelection.Items.Add("Management Information Systems");
            comboSelection.Items.Add("Supply Chain Management");


        }

        private void btbContinue_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
