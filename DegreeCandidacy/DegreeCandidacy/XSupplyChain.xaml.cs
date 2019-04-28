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
                //        if ((int)checked.Items[i] == 3))
                //        {
                //            lstTotalHours.Items.Add(SCM3223);
                //        }

                ListBox listbox = new ListBox();
                CheckBox checkbox = new CheckBox();
                checkbox.Content = "MyCheckBox";

                listbox.Items.Add(checkbox);


            }
         
            }

      




    }
    }

