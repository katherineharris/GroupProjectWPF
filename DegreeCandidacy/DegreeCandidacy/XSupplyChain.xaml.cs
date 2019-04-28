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
    /// Interaction logic for XSupplyChain.xaml
    /// </summary>
    public partial class XSupplyChain : Window
    {
        public XSupplyChain()
        {
            InitializeComponent();
        }

        public IEnumerable<Control> Control { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((SCM3223.IsChecked == true) || (SCM3323.IsChecked == true) || (SCM3523.IsChecked == true) || (SCM4003.IsChecked == true) | (SCM4013.IsChecked == true) || (SCM4323.IsChecked == true) || (scmElective1.IsChecked == true) || (scmElective2.IsChecked == true) || (scmElective3.IsChecked == true) || (scmElective4.IsChecked == true) || (scmElective5.IsChecked == true))
            {

                XSupplyChain scm = new XSupplyChain();
                scm.Show();
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
                //fix here. If 4013 checked then it opens new window. This one should be either/or
                if (SCM4013.IsChecked == false)
                {
                    lstTotalHours.Items.Add("SCM 4013");
                }
                else if((HCB4633.IsChecked == false))
                {
                        lstTotalHours.Items.Add("HCB 4633");
                }
                    }
                    if (SCM4323.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("SCM 4323");
                    }
                    if (scmElective1.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("SCM Elective 1");
                    }
                    if (scmElective2.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("SCM Elective 2");
                    }
                    if (scmElective3.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("SCM Elective 3");
                    }
                    if (scmElective4.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("SCM Elective 4");
                    }
                    if (scmElective5.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("SCM Elective 5");
                    }
                    if (ACCT3313.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("ACCT 3313");
                    }
                    if (freeElective1.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("Free Elective 1");
                    }
                    if (freeElective2.IsChecked == false)
                    {
                        lstTotalHours.Items.Add("Free Elective 2");
                    }




            }

            }

       
    }
    




