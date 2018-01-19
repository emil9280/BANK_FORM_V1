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
    public partial class error_signup : Form
    {
        public error_signup()
        {
            InitializeComponent();
        }

        private void retry_bu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
