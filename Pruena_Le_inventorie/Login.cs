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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Add your login logic here
            MessageBox.Show("Logeo Exitoso");
        }

        private void LinkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.LoginForm = this;  // Pass a reference to this form
            registroForm.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.LoginForm = this;  // Pass a reference to this form
            dashboardForm.Show();
            this.Hide();
        }
    }
}