﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_FORM_V1
{
    public partial class Transfere : Form
    {
        public Transfere()
        {
            InitializeComponent();
        }

        private void cancel_bu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}