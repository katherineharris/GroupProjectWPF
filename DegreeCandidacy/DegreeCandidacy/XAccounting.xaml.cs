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
            if ((ACCT3113.IsChecked == true) || (ACCT3123.IsChecked == true) || (ACCT3313.IsChecked == true) || (ACCT3353.IsChecked == true) | (ACCT3603.IsChecked == true) || (ACCT4543.IsChecked == true) || (freeElective1.IsChecked == true) || (freeElective2.IsChecked == true) || (nonBusinessElectiveI.IsChecked == true) || (nonBusinessElectiveII.IsChecked == true) || (busElectiveI.IsChecked == true) || (busElectiveII.IsChecked == true)|| (busElectiveIII.IsChecked == true) || (busElectiveIV.IsChecked == true))
            {
                MessageBox.Show("Congrats, you're done!");

            }
            else
            {
                if (ACCT3113.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ACCT 3113");
                }
                if (ACCT3123.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ACCT 3123");
                }
                if (ACCT3313.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ACCT 3313");
                }
                if (ACCT3353.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ACCT 3353");
                }
                if (ACCT3603.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ACCT 3603");
                }
                if (ACCT4543.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ACCT 4543");
                }
                if (freeElective1.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Free Elective 1");
                }
                if (freeElective2.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Free Elective 2");
                }
                if (busElectiveI.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Business1Elective I");
                }
                if (busElectiveII.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Business Elective 2");
                }
                if (busElectiveIII.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Business Elective 3");
                }
                if (busElectiveIV.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Business Elective 4");
                }
                if (nonBusinessElectiveI.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Non-Business Elective 1");
                }
                if (nonBusinessElectiveII.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Non-Business Elective 2");
                }
               
            }
        }
    }
}

