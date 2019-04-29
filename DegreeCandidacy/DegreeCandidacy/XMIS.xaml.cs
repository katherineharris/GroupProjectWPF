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
            if ((MIS3013.IsChecked == true) || (MIS3033.IsChecked == true) || (MID3353y.IsChecked == true) || (MIS3373.IsChecked == true) | (MIS3383.IsChecked == true) || (MIS4663.IsChecked == true) || (MIS3213.IsChecked == true) || (MIS3363.IsChecked == true) || (MIS4213.IsChecked == true) || (MIS4413.IsChecked == true) || (MIS4433.IsChecked == true) || (MIS4443.IsChecked == true) || (MIS4493.IsChecked == true) || (MIS4702.IsChecked == true) || (MIS4710.IsChecked == true) || (MIS4960.IsChecked == true) || (freeElective1.IsChecked == true) || (freeElective2.IsChecked == true))
            {

                XFinance fin = new XFinance();
                fin.Show();
                this.Close();
            }
            else
            {
                if (MIS3013.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MIS 3013");
                }
                if (MIS3033.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MIS 3033");
                }
                if (MID3353y.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MIS 3353");
                }
                if (MIS3373.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MIS 3373");
                }
                if (MIS3383.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MIS 3383");
                }
                if (MIS4663.IsChecked == false)
                {
                    lstTotalHours.Items.Add("MIS 4663");
                }

                int totalUD = 0;
                int hoursleft;

                if (MIS3213.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS3363.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4213.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4413.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4433.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4443.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4493.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4702.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4710.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (MIS4960.IsChecked == true)
                {
                    totalUD = totalUD + 3;
                }
                if (totalUD < 17)
                {
                    hoursleft = 17 - totalUD;
                    lstTotalHours.Items.Add($"{hoursleft} hours of Upper Division MIS");
                }
                else
                {
                    lstTotalHours.Items.Add("");
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
}
