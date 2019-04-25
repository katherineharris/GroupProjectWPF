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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btbContinue_Click(object sender, RoutedEventArgs e)
        {
            //checkACCT2113;
            //checkACCT2123;
            //checkBC2813;
            //checkECON1113;
            //checkECON1123;
            //checkMIS2113;
            //txtCreditHours;
            //txtGPACombo;
            //txtOUGPA;

            if((Convert.ToDouble(txtOUGPA)<0.0)||(Convert.ToDouble(txtOUGPA) > 4.0)

            if((checkACCT2113.IsChecked==true)&&(checkACCT2123.IsChecked==true)&&(checkBC2813.IsChecked==true)&& (checkECON1113.IsChecked == true) && (checkMIS2113.IsChecked == true) && (checkBC2813.IsChecked == true)&&(Convert.ToDouble(txtOUGPA)>=2.5)&& (Convert.ToDouble(txtGPACombo) >= 2.5)&& (Convert.ToDouble(txtCreditHours) >= 2.5))
            {
                Window2 win2 = new Window2();
                win2.Show();
                this.Close();
            }
            else
            {

            }




            
        }
    }
}
