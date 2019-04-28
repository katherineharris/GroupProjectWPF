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

            if((Convert.ToDouble(txtOUGPA.Text)<0.0)||(Convert.ToDouble(txtOUGPA.Text) > 4.0))
            {
                MessageBox.Show("Please enter a valid OU GPA");
                txtOUGPA.Clear();
            }
            else if((Convert.ToDouble(txtGPACombo.Text) < 0.0) || (Convert.ToDouble(txtGPACombo.Text) > 4.0))
            {
                MessageBox.Show("Please enter a valid Combined GPA");
                txtGPACombo.Clear();
            }
            else if ((Convert.ToDouble(txtCreditHours.Text) < 0.0) || (Convert.ToDouble(txtCreditHours.Text) > 4.0))
            {
                MessageBox.Show("Please enter a valid GPA for the prerequisite courses");
                txtCreditHours.Clear();
            }

            if ((checkACCT2113.IsChecked == true) && (checkACCT2123.IsChecked == true) && (checkBC2813.IsChecked == true) && (checkECON1113.IsChecked == true) && (checkMIS2113.IsChecked == true) && (checkBC2813.IsChecked == true) && (Convert.ToDouble(txtOUGPA.Text) >= 2.5) && (Convert.ToDouble(txtGPACombo.Text) >= 2.5) && (Convert.ToDouble(txtCreditHours.Text) >= 3.0)) 
            {
                Window2 win2 = new Window2();
                win2.Show();
                this.Close();
            }
            else
            {
                if (checkACCT2113.IsChecked == false)
                {
                    lstNeed.Items.Add("ACCT 2113");
                }
                if (checkACCT2123.IsChecked == false)
                {
                    lstNeed.Items.Add("ACCT 2123");
                }
                if (checkBC2813.IsChecked == false)
                {
                    lstNeed.Items.Add("B C 2813");
                }
                if (checkECON1113.IsChecked == false)
                {
                    lstNeed.Items.Add("ECON 1113");
                }
                if (checkECON1123.IsChecked == false)
                {
                    lstNeed.Items.Add("ECON 1123");
                }
                if (checkMIS2113.IsChecked == false)
                {
                    lstNeed.Items.Add("MIS 2113");
                }
                if ((Convert.ToDouble(txtCreditHours.Text) < 3.0)&& (Convert.ToDouble(txtCreditHours.Text) >= 0.0))
                {
                    lstNeed.Items.Add("3.0 Prerequisites GPA");
                }
                if ((Convert.ToDouble(txtOUGPA.Text) < 2.5) && (Convert.ToDouble(txtOUGPA.Text) >=0.0))
                {
                    lstNeed.Items.Add("2.5 OU GPA");
                }
                if ((Convert.ToDouble(txtGPACombo.Text) < 3.0)&&(Convert.ToDouble(txtGPACombo.Text) >= 0.0))
                {
                    lstNeed.Items.Add("3.0 Combined GPA");
                }
            }




            
        }
    }
}
