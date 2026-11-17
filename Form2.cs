using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnNavToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frmRegister = new FormRegister();
            frmRegister.Show();
        }
    }
}
