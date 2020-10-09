using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronIDE
{
    public partial class Code : Form
    {
        public Code(string modelo)
        {
            InitializeComponent();

            txt_code.Text = modelo;
        }

        private void Code_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form main = Main.getInstance();
            main.Show();
            main.Activate();
        }
    }
}
