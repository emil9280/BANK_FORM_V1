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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form can_1 = new Form1();
            can_1.Show();
        }

        private void add_user_Click(object sender, EventArgs e)
        {

        }
    }
}
