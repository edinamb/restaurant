﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comanda.Text = Form1.c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
