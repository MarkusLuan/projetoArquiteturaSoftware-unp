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
        private static Form instancia;

        public Main()
        {
            instancia = this;

            InitializeComponent();
        }

        public static Form getInstance()
        {
            if (instancia == null) instancia = new Main();

            return instancia;
        }

        private void bt_web_Click(object sender, EventArgs e)
        {
            string modelo = File.ReadAllText(@"modelos\web.py");

            Form novoWeb = new NovoWeb(modelo);
            novoWeb.ShowDialog();
        }
    }
}
