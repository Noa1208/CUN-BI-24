using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_inventorie
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        public LoginForm LoginForm { get; internal set; }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Add your registration logic here
            MessageBox.Show("Te has registrado");
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoginForm != null)
            {
                LoginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login form not available.");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (LoginForm != null && !LoginForm.Visible)
            {
                //LoginForm.Show();
                LoginForm.Close();

            }
        }

      
    }
}
