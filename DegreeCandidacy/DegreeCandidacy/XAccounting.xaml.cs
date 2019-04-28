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
    /// Interaction logic for XAccounting.xaml
    /// </summary>
    public partial class XAccounting : Window
    {
        public XAccounting()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((ACCT3113.IsChecked == true) || (ACCT3123.IsChecked == true) || (ACCT3313.IsChecked == true) || (ACCT3353.IsChecked == true) | (ACCT3603.IsChecked == true) || (ACCT4543.IsChecked == true) || (freeElective1.IsChecked == true) || (freeElective2.IsChecked == true) || (nonBusinessElectiveI.IsChecked == true) || (nonBusinessElectiveII.IsChecked == true) || (busElectiveI.IsChecked == true) || (busElectiveII).IsChecked == true)|| (busElectiveIII.IsChecked == true) || (busElectiveIV.IsChecked == true))
            {

                XAccounting acct = new XAccounting();
                acct.Show();
                this.Close();
            }
            else
            {
                if (SCM3223.IsChecked == false)
                {
                    lstTotalHours.Items.Add("SCM 3223");
                }
                if (SCM3323.IsChecked == false)
                {
                    lstTotalHours.Items.Add("SCM 3323");
                }
                if (SCM3523.IsChecked == false)
                {
                    lstTotalHours.Items.Add("SCM 3523");
                }
                if (SCM4003.IsChecked == false)
                {
                    lstTotalHours.Items.Add("SCM 4003");
                }
            }
        }
    }
}

