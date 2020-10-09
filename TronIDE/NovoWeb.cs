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

        private bool camposInvalidos
        {
            get
            {
                if (string.IsNullOrEmpty(txt_nomeProjeto.Text))
                {
                    MessageBox.Show("O nome do projeto não pode ser vazio");
                    txt_nomeProjeto.Focus();
                    return true;
                }

                if (string.IsNullOrEmpty(txt_pasta.Text))
                {
                    MessageBox.Show("A pasta não pode ser vazio");
                    txt_pasta.Focus();
                    return true;
                }

                return false;
            }
        }

        private void bt_iniciarProjeto_Click(object sender, EventArgs e)
        {
            if (camposInvalidos)
            {
                return;
            }

            Form main = new Main();
            main.Hide();
            this.Close();

            Form code = new Code(modelo);
            code.Show();
            code.Activate(); // Ativa o Foco
        }
    }
}
