using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronIDE
{
    public partial class Code : Form
    {
        private Projeto projeto;

        public Code(Projeto projeto)
        {
            this.projeto = projeto;

            InitializeComponent();
            Text = projeto.getNome() + " - Code";

            txt_code.Text = projeto.getModelo();

            imageList1.Images.Add(Image.FromFile(@"imgs\icon_folder.png"));
            imageList1.Images.Add(Image.FromFile(@"imgs\icon_file.png"));

            DirectoryInfo directoryInfo = new DirectoryInfo(projeto.getPasta());
            if (directoryInfo.Exists)
            {
                BuildTree(directoryInfo, null);
            }
        }

        private void BuildTree(DirectoryInfo dir, TreeNode node)
        {
            if (node == null)
            {
                node = treeView1.Nodes.Add(dir.Name);
            } else
            {
                node = node.Nodes.Add(dir.Name);
            }

            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                BuildTree(subdir, node);
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                TreeNode tmpNode = node.Nodes.Add(file.Name);
                tmpNode.ImageIndex = 1; //Icone de arquivo
                tmpNode.SelectedImageIndex = 1; //Icone de arquivo
            }

            node.ImageIndex = 0; //Icone de pasta
            node.SelectedImageIndex = 0; //Icone de pasta
        }

        private void Code_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form main = Main.getInstance();
            main.Show();
            main.Activate();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode noAtual = treeView1.SelectedNode;
            if (!noAtual.Text.EndsWith(".py")) return;

            txt_code.Text = "";
            txt_code.Text = File.ReadAllText(noAtual.FullPath);
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            string cmd = "cd \"" + projeto.getPasta() + "\" " +
                " && python main.py";

            ProcessStartInfo proInfo = new ProcessStartInfo();
            proInfo.FileName = "cmd";
            proInfo.Arguments = "/c " + cmd;

            Process process = new Process();
            process.StartInfo = proInfo;
            process.Start();
        }
    }
}
