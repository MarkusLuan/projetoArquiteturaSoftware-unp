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

        private void Code_Deactivate(object sender, EventArgs e)
        {
            Form main = new Main();
            main.Show();
            main.Activate();
            this.Close();
        }
    }
}
