namespace Loja.View
{
    partial class PermissaoAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissaoAdm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LblSolucao = new System.Windows.Forms.Label();
            this.LblNumeroErro = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Linha = new System.Windows.Forms.Panel();
            this.ImgSenha = new System.Windows.Forms.PictureBox();
            this.ImgUsuario = new System.Windows.Forms.PictureBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(60, 88);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(142, 138);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // LblSolucao
            // 
            this.LblSolucao.AutoSize = true;
            this.LblSolucao.BackColor = System.Drawing.Color.White;
            this.LblSolucao.Location = new System.Drawing.Point(35, 250);
            this.LblSolucao.Name = "LblSolucao";
            this.LblSolucao.Size = new System.Drawing.Size(193, 13);
            this.LblSolucao.TabIndex = 12;
            this.LblSolucao.Text = "Informe as credenciais de administrador";
            // 
            // LblNumeroErro
            // 
            this.LblNumeroErro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroErro.Location = new System.Drawing.Point(77, 21);
            this.LblNumeroErro.Name = "LblNumeroErro";
            this.LblNumeroErro.Size = new System.Drawing.Size(185, 45);
            this.LblNumeroErro.TabIndex = 11;
            this.LblNumeroErro.Text = "Essa ação necessita de acesso de administrador";
            this.LblNumeroErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(90, 388);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(84, 30);
            this.BtnEntrar.TabIndex = 26;
            this.BtnEntrar.Text = "Confirmar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(71, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1);
            this.panel1.TabIndex = 25;
            // 
            // Linha
            // 
            this.Linha.BackColor = System.Drawing.Color.Orange;
            this.Linha.Location = new System.Drawing.Point(71, 308);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(130, 1);
            this.Linha.TabIndex = 24;
            // 
            // ImgSenha
            // 
            this.ImgSenha.Image = ((System.Drawing.Image)(resources.GetObject("ImgSenha.Image")));
            this.ImgSenha.Location = new System.Drawing.Point(38, 329);
            this.ImgSenha.Name = "ImgSenha";
            this.ImgSenha.Size = new System.Drawing.Size(24, 28);
            this.ImgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgSenha.TabIndex = 23;
            this.ImgSenha.TabStop = false;
            // 
            // ImgUsuario
            // 
            this.ImgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ImgUsuario.Image")));
            this.ImgUsuario.Location = new System.Drawing.Point(40, 278);
            this.ImgUsuario.Name = "ImgUsuario";
            this.ImgUsuario.Size = new System.Drawing.Size(24, 40);
            this.ImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUsuario.TabIndex = 22;
            this.ImgUsuario.TabStop = false;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.White;
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(71, 332);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(130, 16);
            this.TxtSenha.TabIndex = 21;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.White;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(71, 286);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(130, 16);
            this.TxtUsuario.TabIndex = 20;
            // 
            // PermissaoAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 437);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.ImgSenha);
            this.Controls.Add(this.ImgUsuario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LblSolucao);
            this.Controls.Add(this.LblNumeroErro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PermissaoAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PermissaoAdm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LblSolucao;
        private System.Windows.Forms.Label LblNumeroErro;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Linha;
        private System.Windows.Forms.PictureBox ImgSenha;
        private System.Windows.Forms.PictureBox ImgUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
    }
}