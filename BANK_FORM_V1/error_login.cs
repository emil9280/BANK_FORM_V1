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
    public partial class error_login : Form
    {
        public error_login()
        {
            InitializeComponent();
        }

        private void Retry_button_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            TextBox txt = (TextBox)frm.Controls.Find("picival", true)[0];
            txt.Text = " ";
            Form error = new error_login();
            error.Close();
        }
    }
}
