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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public LoginForm LoginForm { get; internal set; }
        private void EndResponsive()
        {
            if (this.Width < 450)
            {
                Tabla2.ColumnStyles[1].Width = 350;

            }
            else if (this.Width < 1008)
            {
                Tabla2.ColumnStyles[1].Width = Tabla2.Width - (chart1.Width + chart1.Margin.Right);

            }
            else
            {
                Tabla2.ColumnStyles[1].Width = Tabla2.Width - (chart1.Width + chart2.Width + chart1.Margin.Right + chart2.Margin.Right);
            }
        }

        private void Dashboard_ResizeEnd(object sender, EventArgs e)
        {
            EndResponsive();
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
