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
                //need to add if checked
                //assign value to each cheched as 3?
                Window3 win3 = new Window3();
                win3.Show();
                this.Close();
            }
         

                //int SCM3223 = 3;
                //foreach (Control control in this.Control)               
                //    if (control is CheckBox)
                //    {
                //        SCM3223 = SCM3223 + Convert.ToInt32(control.Tag);
                //        lstTotalHours.Items.Add(SCM3223);
                //    }
            }





        }
    }

