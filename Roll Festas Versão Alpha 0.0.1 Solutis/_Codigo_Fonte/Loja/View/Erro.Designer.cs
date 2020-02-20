namespace Loja.View
{
    partial class Erro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Erro));
            this.LblNumeroErro = new System.Windows.Forms.Label();
            this.LblSolucao = new System.Windows.Forms.Label();
            this.LblSolucao02 = new System.Windows.Forms.Label();
            this.LblSolucao03 = new System.Windows.Forms.Label();
            this.LblSolucao04 = new System.Windows.Forms.Label();
            this.LblSolucao05 = new System.Windows.Forms.Label();
            this.TxtErro = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumeroErro
            // 
            this.LblNumeroErro.AutoSize = true;
            this.LblNumeroErro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroErro.Location = new System.Drawing.Point(55, 23);
            this.LblNumeroErro.Name = "LblNumeroErro";
            this.LblNumeroErro.Size = new System.Drawing.Size(112, 17);
            this.LblNumeroErro.TabIndex = 0;
            this.LblNumeroErro.Text = "Código do erro: ";
            // 
            // LblSolucao
            // 
            this.LblSolucao.AutoSize = true;
            this.LblSolucao.BackColor = System.Drawing.Color.White;
            this.LblSolucao.Location = new System.Drawing.Point(7, 63);
            this.LblSolucao.Name = "LblSolucao";
            this.LblSolucao.Size = new System.Drawing.Size(100, 14);
            this.LblSolucao.TabIndex = 3;
            this.LblSolucao.Text = "Possíveis soluções";
            // 
            // LblSolucao02
            // 
            this.LblSolucao02.AutoSize = true;
            this.LblSolucao02.BackColor = System.Drawing.Color.White;
            this.LblSolucao02.Location = new System.Drawing.Point(12, 87);
            this.LblSolucao02.Name = "LblSolucao02";
            this.LblSolucao02.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao02.TabIndex = 4;
            // 
            // LblSolucao03
            // 
            this.LblSolucao03.AutoSize = true;
            this.LblSolucao03.BackColor = System.Drawing.Color.White;
            this.LblSolucao03.Location = new System.Drawing.Point(12, 115);
            this.LblSolucao03.Name = "LblSolucao03";
            this.LblSolucao03.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao03.TabIndex = 5;
            // 
            // LblSolucao04
            // 
            this.LblSolucao04.AutoSize = true;
            this.LblSolucao04.BackColor = System.Drawing.Color.White;
            this.LblSolucao04.Location = new System.Drawing.Point(12, 140);
            this.LblSolucao04.Name = "LblSolucao04";
            this.LblSolucao04.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao04.TabIndex = 6;
            // 
            // LblSolucao05
            // 
            this.LblSolucao05.AutoSize = true;
            this.LblSolucao05.BackColor = System.Drawing.Color.White;
            this.LblSolucao05.Location = new System.Drawing.Point(12, 165);
            this.LblSolucao05.Name = "LblSolucao05";
            this.LblSolucao05.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao05.TabIndex = 7;
            // 
            // TxtErro
            // 
            this.TxtErro.BackColor = System.Drawing.Color.White;
            this.TxtErro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtErro.Location = new System.Drawing.Point(23, 213);
            this.TxtErro.Multiline = true;
            this.TxtErro.Name = "TxtErro";
            this.TxtErro.ReadOnly = true;
            this.TxtErro.Size = new System.Drawing.Size(519, 52);
            this.TxtErro.TabIndex = 8;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(406, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(142, 138);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 9;
            this.Logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Erro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.TxtErro);
            this.Controls.Add(this.LblSolucao05);
            this.Controls.Add(this.LblSolucao04);
            this.Controls.Add(this.LblSolucao03);
            this.Controls.Add(this.LblSolucao02);
            this.Controls.Add(this.LblSolucao);
            this.Controls.Add(this.LblNumeroErro);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Erro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erro";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeroErro;
        private System.Windows.Forms.Label LblSolucao;
        private System.Windows.Forms.Label LblSolucao02;
        private System.Windows.Forms.Label LblSolucao03;
        private System.Windows.Forms.Label LblSolucao04;
        private System.Windows.Forms.Label LblSolucao05;
        private System.Windows.Forms.TextBox TxtErro;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}