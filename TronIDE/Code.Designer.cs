namespace TronIDE
{
    partial class Code
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
            this.components = new System.ComponentModel.Container();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_salvar = new System.Windows.Forms.PictureBox();
            this.bt_executar = new System.Windows.Forms.PictureBox();
            this.bt_resetar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bt_salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_executar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_code.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.ForeColor = System.Drawing.Color.Cyan;
            this.txt_code.Location = new System.Drawing.Point(205, 12);
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(708, 426);
            this.txt_code.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(176, 426);
            this.treeView1.TabIndex = 1;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salvar.Image = global::TronIDE.Properties.Resources.icon_save;
            this.bt_salvar.Location = new System.Drawing.Point(100, 449);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(62, 34);
            this.bt_salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_salvar.TabIndex = 3;
            this.bt_salvar.TabStop = false;
            this.bt_salvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // bt_executar
            // 
            this.bt_executar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_executar.Image = global::TronIDE.Properties.Resources.icon_execute;
            this.bt_executar.Location = new System.Drawing.Point(194, 449);
            this.bt_executar.Name = "bt_executar";
            this.bt_executar.Size = new System.Drawing.Size(47, 34);
            this.bt_executar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_executar.TabIndex = 2;
            this.bt_executar.TabStop = false;
            this.bt_executar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // bt_resetar
            // 
            this.bt_resetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_resetar.Location = new System.Drawing.Point(12, 455);
            this.bt_resetar.Name = "bt_resetar";
            this.bt_resetar.Size = new System.Drawing.Size(75, 23);
            this.bt_resetar.TabIndex = 4;
            this.bt_resetar.Text = "Resetar";
            this.bt_resetar.UseVisualStyleBackColor = true;
            this.bt_resetar.Click += new System.EventHandler(this.btResetar_Click);
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 490);
            this.Controls.Add(this.bt_resetar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_executar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_code);
            this.Name = "Code";
            this.Text = "Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Code_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bt_salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_executar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox bt_executar;
        private System.Windows.Forms.PictureBox bt_salvar;
        private System.Windows.Forms.Button bt_resetar;
    }
}