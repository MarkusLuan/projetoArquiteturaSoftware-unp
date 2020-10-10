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
    public partial class Code : Form
    {
        public Code(string modelo)
        {
            InitializeComponent();

            txt_code.Text = modelo;

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\marku\Documents\projetos\Android");
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
                node.Nodes.Add(file.Name);
            }
        }

        private void Code_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form main = Main.getInstance();
            main.Show();
            main.Activate();
        }
    }
}
