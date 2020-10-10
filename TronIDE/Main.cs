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
            Text = "TronIDE";
        }

        public static Form getInstance()
        {
            if (instancia == null) instancia = new Main();

            return instancia;
        }

        private void bt_web_Click(object sender, EventArgs e)
        {
            string modelo = File.ReadAllText(@"modelos\web.py", Encoding.UTF8);
            Projeto projeto = new Projeto(modelo);

            Form novoWeb = new NovoWeb(projeto);
            novoWeb.ShowDialog();
        }
    }
}
