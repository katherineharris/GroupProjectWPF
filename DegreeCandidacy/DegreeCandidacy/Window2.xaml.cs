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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btbContinue_Click(object sender, RoutedEventArgs e)
        {
            if ((Convert.ToDouble(txtOUGPA.Text) < 0.0) || (Convert.ToDouble(txtOUGPA.Text) > 4.0))
            {
                MessageBox.Show("Please enter a valid OU GPA");
                txtOUGPA.Clear();
            }
            else if ((Convert.ToDouble(txtGPACombo.Text) < 0.0) || (Convert.ToDouble(txtGPACombo.Text) > 4.0))
            {
                MessageBox.Show("Please enter a valid Combined GPA");
                txtGPACombo.Clear();
            }
            else if (Convert.ToInt32(txtCreditHours.Text) < 0)
            {
                MessageBox.Show("Please enter a valid number of Credit Hours completed");
                txtCreditHours.Clear();
            }

            if ((checkENGL1113.IsChecked == true) && (checkENGL1213.IsChecked == true) && (checkCOMM1113.IsChecked == true) && (checkMATH2123.IsChecked == true) && (checkACCT2123.IsChecked == true) && (checkBAD1001.IsChecked == true) && (Convert.ToDouble(txtOUGPA.Text) >= 2.5) && (Convert.ToDouble(txtGPACombo.Text) >= 2.5) && (Convert.ToInt32(txtCreditHours.Text) >= 60))
            {
                Window3 win3 = new Window3();
                win3.Show();
                this.Close();
            }
            else
            {
                if (checkENGL1113.IsChecked == false)
                {
                    lstNeed.Items.Add("ENGL 1113");
                }
                if (checkENGL1213.IsChecked == false)
                {
                    lstNeed.Items.Add("ENGL/EXPO 1213");
                }
                if (checkCOMM1113.IsChecked == false)
                {
                    lstNeed.Items.Add("COMM 1113/2613");
                }
                if (checkMATH2123.IsChecked == false)
                {
                    lstNeed.Items.Add("MATH 2123");
                }
                if (checkACCT2123.IsChecked == false)
                {
                    lstNeed.Items.Add("ACCT 2123");
                }
                if (checkBAD1001.IsChecked == false)
                {
                    lstNeed.Items.Add("B AD 1001");
                }
                if ((Convert.ToInt32(txtCreditHours.Text) < 60) && (Convert.ToInt32(txtCreditHours.Text) >= 0.0))
                {
                    lstNeed.Items.Add("60 Credit Hours (Junior Standing)");
                }
                if ((Convert.ToDouble(txtOUGPA.Text) < 2.5) && (Convert.ToDouble(txtOUGPA.Text) >= 0.0))
                {
                    lstNeed.Items.Add("2.5 OU GPA");
                }
                if ((Convert.ToDouble(txtGPACombo.Text) < 3.0) && (Convert.ToDouble(txtGPACombo.Text) >= 0.0))
                {
                    lstNeed.Items.Add("3.0 Combined GPA");
                }
            }
            
        }
    }
}
