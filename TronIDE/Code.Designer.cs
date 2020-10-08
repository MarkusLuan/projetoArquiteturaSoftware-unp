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
            this.txt_code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_code
            // 
            this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_code.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.ForeColor = System.Drawing.Color.Red;
            this.txt_code.Location = new System.Drawing.Point(12, 12);
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(776, 426);
            this.txt_code.TabIndex = 0;
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_code);
            this.Name = "Code";
            this.Text = "Code";
            this.VisibleChanged += new System.EventHandler(this.Code_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_code;
    }
}