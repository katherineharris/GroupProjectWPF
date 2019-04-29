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
            if ((MKT3053.IsChecked == true) || (MKT3323.IsChecked == true) || (MKT3323.IsChecked == true) || (MKT4123.IsChecked == true) | (MKT4333.IsChecked == true) || (mktAdvertising.IsChecked == true) || (mktFranchising.IsChecked == true) || (mktHealthcareBusiness.IsChecked == true) || (mktSecondMajor.IsChecked == true) || (mktSupplyChainMgt.IsChecked == true) || (freeElective1UDMkt.IsChecked == true) || (freeElective2UDMkt.IsChecked == true) || (freeElective3UDMkt.IsChecked == true) || (freeElective4UDMkt.IsChecked == true) || (freeElective5UDMkt.IsChecked == true) || (freeElective6UDMkt.IsChecked == true) || (freeElectiveMkt.IsChecked == true))
            {
                
                MessageBox.Show("Congrats, you're done!");
            }


            else
            {
                if (MKT3053.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT 3053");
                }
                if (MKT3323.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT 3323");
                }
                if (MKT3323.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT 3323");
                }
                if (MKT4123.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT 4123");
                }
                if (MKT4333.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT 4333");
                }
                if (mktAdvertising.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT Advertising");
                }
                if (mktFranchising.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT Franchising");
                }
                if (mktHealthcareBusiness.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT Healthcare Business");
                }
                if (mktSecondMajor.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT Second Major");
                }
                if (mktSupplyChainMgt.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MKT Supply Chain MGT");
                }
                int totalUD = 0;
                int hoursleft;

                if (freeElective1UDMkt.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (freeElective2UDMkt.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (freeElective3UDMkt.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (freeElective4UDMkt.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (freeElective5UDMkt.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (freeElective6UDMkt.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (totalUD < 12)
                {
                    hoursleft = 12 - totalUD;
                    lstTotalHours.Items.Add($"You need {totalUD} more Upper Division Electives");
                }
                else
                {
                    lstTotalHours.Items.Add("");

                }
                if (freeElectiveMkt.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Marketing Free Elective");

                }
            }
        }
    }
}
