using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronIDE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bt_web_Click(object sender, EventArgs e)
        {
            string modelo = File.ReadAllText(@"C:\Users\marku\Documents\projetos\VisualStudio Projs\TronIDE\TronIDE\modelos\web.py");

            Form novoWeb = new NovoWeb(modelo);
            novoWeb.ShowDialog();
        }
    }
}
