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
        private int User_ID = 10;

        public Form2()
        {            
            InitializeComponent();
            Pulled_data();
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

        private void Pulled_data()
        {
            User_ID_number_label.Text = "User ID:" + User_ID;
        }

    }
}