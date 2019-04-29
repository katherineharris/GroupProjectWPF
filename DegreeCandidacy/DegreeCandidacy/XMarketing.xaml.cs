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
    /// Interaction logic for XMarketing.xaml
    /// </summary>
    public partial class XMarketing : Window
    {
        public XMarketing()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((MKT3053.IsChecked == true) || (MKT3323.IsChecked == true) || (MKT3513.IsChecked == true) || (MKT4123.IsChecked == true) | (MKT4333.IsChecked == true) || (mktAdvertising.IsChecked == true) || (mktFranchising.IsChecked == true) || (mktHealthcareBusiness.IsChecked == true) || (mktSecondMajor.IsChecked == true) || (mktSupplyChainMgt.IsChecked == true) || (freeElective1UDMkt.IsChecked == true) || (freeElective2UDMkt.IsChecked == true) || (freeElective3UDMkt.IsChecked == true) || (freeElective4UDMkt.IsChecked == true) ||(freeElective5UDMkt.IsChecked==true)|| (freeElective6UDMkt.IsChecked==true))
            {

                XMarketing mkt = new XMarketing();
                mkt.Show();
                this.Close();
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
