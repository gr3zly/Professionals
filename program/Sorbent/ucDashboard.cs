using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sorbent
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(245, 245, 250); // очень светлый серо-голубой фон
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
