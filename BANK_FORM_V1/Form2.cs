using System;
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
    public partial class Form2 : Form
    {
        private string balance_1;
        private string balance_2;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            Form Help = new help();
            Help.Show();
        }

        private void Transfere_button_Click(object sender, EventArgs e)
        {
            Form trans = new Transfere();
            trans.Show();
        }

    }
}