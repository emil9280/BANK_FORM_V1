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
    public partial class Transfere : Form
    {
        public List<string> From { get; set; }
        private List<string> Too { get; set; }
        private double Amount;
        public Transfere()
        {
            InitializeComponent();
            //From =
            //Too =
            /*for(int i= 0; i< From.Count; i++)
            {
                From_CoBo.Items.Add(From);
                Too_CoBo.Items.Add(Too);
            }*/
        }

        private void cancel_bu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transfere_Bu_Click(object sender, EventArgs e)
        {
            check_from();
            check_too();

        }
        private void check_from()
        {
            if (From_CoBo.SelectedItem == null)
            {
                Error_lable.Text = "please select an from account";
                return;
            }
            else
            {
                return;
            }
        }
        private void check_too()
        {
            if (Too_CoBo.SelectedItem == null)
            {
                Error_lable.Text = "please select an Too account";
                return;
            }
            else
            {
                return;
            }
        }
    }
}
