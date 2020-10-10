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
    public partial class NovoWeb : Form
    {
        private SeleniumDown seleniumDown = new SeleniumDown();
        private List<Version> versoes;
        private Projeto projeto;

        public NovoWeb(Projeto projeto)
        {
            this.projeto = projeto;
            versoes = seleniumDown.versoes;

            //Limitar as 10 ultimas versões
            versoes = versoes.GetRange((versoes.Count() - 10), 10);

            InitializeComponent();
            Text = "Novo Projeto Web";
         
            sel_versao.Items.Clear();
            sel_versao.Items.AddRange(versoes.ToArray());
            sel_versao.SelectedItem = versoes.Last();
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

            projeto.setNome(txt_nomeProjeto.Text);
            projeto.setPasta(txt_pasta.Text);

            try
            {
                if (!Directory.Exists(projeto.getPasta()))
                {
                    Directory.CreateDirectory(projeto.getPasta());
                }
            }
            catch
            {
                MessageBox.Show("Erro: Não foi possivel criar a pasta");
                return;
            }

            bool baixouSelenium = seleniumDown.baixarDriver((Version) sel_versao.SelectedItem, projeto.getPasta());
            if (!baixouSelenium)
            {
                return;
            }

            try
            {
                File.WriteAllText(projeto.getPasta() + @"\main.py", projeto.getModelo());
            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar arquivo main.py\n" + ex.Message);
                return;
            }

            Form main = Main.getInstance();
            main.Hide();
            this.Close();

            Form code = new Code(projeto);
            code.Show();
            code.Activate(); // Ativa o Foco
        }
    }
}
