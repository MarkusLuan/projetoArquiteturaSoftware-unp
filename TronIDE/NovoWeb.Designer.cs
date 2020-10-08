namespace TronIDE
{
    partial class NovoWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nomeProjeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sel_versao = new System.Windows.Forms.ComboBox();
            this.bt_iniciarProjeto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bt_pasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nomeProjeto
            // 
            this.txt_nomeProjeto.Location = new System.Drawing.Point(41, 49);
            this.txt_nomeProjeto.Name = "txt_nomeProjeto";
            this.txt_nomeProjeto.Size = new System.Drawing.Size(216, 20);
            this.txt_nomeProjeto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Projeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasta";
            // 
            // txt_pasta
            // 
            this.txt_pasta.Location = new System.Drawing.Point(41, 121);
            this.txt_pasta.Name = "txt_pasta";
            this.txt_pasta.Size = new System.Drawing.Size(216, 20);
            this.txt_pasta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Versão do Chrome";
            // 
            // sel_versao
            // 
            this.sel_versao.FormattingEnabled = true;
            this.sel_versao.Items.AddRange(new object[] {
            "1.0.5",
            "5.2.4",
            "5.8.6",
            "8.2.4"});
            this.sel_versao.Location = new System.Drawing.Point(41, 193);
            this.sel_versao.Name = "sel_versao";
            this.sel_versao.Size = new System.Drawing.Size(216, 21);
            this.sel_versao.TabIndex = 6;
            // 
            // bt_iniciarProjeto
            // 
            this.bt_iniciarProjeto.Location = new System.Drawing.Point(302, 270);
            this.bt_iniciarProjeto.Name = "bt_iniciarProjeto";
            this.bt_iniciarProjeto.Size = new System.Drawing.Size(75, 23);
            this.bt_iniciarProjeto.TabIndex = 7;
            this.bt_iniciarProjeto.Text = "Iniciar";
            this.bt_iniciarProjeto.UseVisualStyleBackColor = true;
            this.bt_iniciarProjeto.Click += new System.EventHandler(this.bt_iniciarProjeto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_pasta
            // 
            this.bt_pasta.Location = new System.Drawing.Point(263, 119);
            this.bt_pasta.Name = "bt_pasta";
            this.bt_pasta.Size = new System.Drawing.Size(27, 23);
            this.bt_pasta.TabIndex = 8;
            this.bt_pasta.Text = "...";
            this.bt_pasta.UseVisualStyleBackColor = true;
            this.bt_pasta.Click += new System.EventHandler(this.bt_pasta_Click);
            // 
            // NovoWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 305);
            this.Controls.Add(this.bt_pasta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_iniciarProjeto);
            this.Controls.Add(this.sel_versao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomeProjeto);
            this.Name = "NovoWeb";
            this.Text = "NovoWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sel_versao;
        private System.Windows.Forms.Button bt_iniciarProjeto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button bt_pasta;
    }
}