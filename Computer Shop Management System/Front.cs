﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void explore_Click(object sender, EventArgs e)
        {
            catalogue ca = new catalogue();
            ca.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            whosgonnalogin lo = new whosgonnalogin();
            lo.ShowDialog();
        }
    }
}
