﻿using System;
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

            int SCM3223 = 3;
            foreach (Control control in this.Control)               
                if (control is CheckBox)
                {
                    SCM3223 = SCM3223 + Convert.ToInt32(control.Tag);
                    lstTotalHours.Items.Add(SCM3223);
                }
            }





        }
    }

