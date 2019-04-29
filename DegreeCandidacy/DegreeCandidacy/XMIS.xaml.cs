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
    /// Interaction logic for XMIS.xaml
    /// </summary>
    public partial class XMIS : Window
    {
        public XMIS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((FIN3403.IsChecked == true) || (FIN3453.IsChecked == true) || (FIN3503.IsChecked == true) || (FIN3603.IsChecked == true) | (FIN3960.IsChecked == true) || (FIN3980.IsChecked == true) || (FIN4113.IsChecked == true) || (FIN4133.IsChecked == true) || (FIN4403.IsChecked == true) || (FIN4413.IsChecked == true) || (FIN4513.IsChecked == true) || (FIN4613.IsChecked == true) || (FIN4700.IsChecked == true) || (FIN4713.IsChecked == true) || (ECON3113.IsChecked == true) || (ACCT3113.IsChecked == true) || (ACCT3123.IsChecked == true) || (freeElective1Fin.IsChecked == true) || (freeElective2Fin.IsChecked == true) || (freeElective1UDFin.IsChecked == true) || (freeElective2UDFin.IsChecked == true))
            {

                XFinance fin = new XFinance();
                fin.Show();
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
                if (ECON3113.IsChecked == false)
                {
                    lstTotalHours.Items.Add("ECON 3113");
                }
                if (freeElective1Fin.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Free Elective 1");
                }
                if (freeElective2Fin.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Free Elective 2");
                }
                if (freeElective1UDFin.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Upper Division Free Elective 1");
                }
                if (freeElective2UDFin.IsChecked == false)
                {
                    lstTotalHours.Items.Add("Upper Division Free Elective 2");
                }
                if (FIN3403.IsChecked == false)
                {
                    lstTotalHours.Items.Add("FIN 3403");
                }
                if (FIN3453.IsChecked == false)
                {
                    lstTotalHours.Items.Add("FIN 3453");
                }
                if (FIN3503.IsChecked == false)
                {
                    lstTotalHours.Items.Add("FIN 3503");
                }
                if (FIN3603.IsChecked == false)
                {
                    lstTotalHours.Items.Add("FIN 3603");
                }

                //how do i get it to only add 3 of the x amount of courses?


                //choose 9 hours from here
                int totalUDElectives = 0;
                int UDhoursLeft;


                if (FIN3960.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN3980.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4113.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4133.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4403.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4413.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4513.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4613.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4713.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (FIN4700.IsChecked == true)
                {
                    totalUDElectives = totalUDElectives + 3;
                }
                if (totalUDElectives < 9)
                {
                    UDhoursLeft = 9 - totalUDElectives;
                    lstTotalHours.Items.Add($"You need {UDhoursLeft} more Upper Division Electives");
                }
                else
                {
                    lstTotalHours.Items.Add("");
                }
            }
    }
}
