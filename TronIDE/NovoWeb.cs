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
    public partial class NovoWeb : Form
    {
        private string modelo;

        public NovoWeb(string modelo)
        {
            this.modelo = modelo;

            InitializeComponent();
        }

        private void bt_pasta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderDialog.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txt_pasta.Text = folderDialog.SelectedPath + @"\" + txt_nomeProjeto.Text + @"\";
            }
        }

        private void bt_iniciarProjeto_Click(object sender, EventArgs e)
        {
            this.Close();

            Form main = new Main();
            main.Hide();

            Form code = new Code(modelo);
            code.Show();
            code.Activate(); // Ativa o Foco
        }
    }
}
