namespace Loja
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblKeven = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LblAno = new System.Windows.Forms.Label();
            this.ImgUsuario = new System.Windows.Forms.PictureBox();
            this.ImgSenha = new System.Windows.Forms.PictureBox();
            this.Linha = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.White;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(88, 208);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(130, 16);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.Text = "keven";
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.White;
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(88, 254);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(130, 16);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.Text = "123";
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // LblKeven
            // 
            this.LblKeven.AutoSize = true;
            this.LblKeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKeven.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblKeven.Location = new System.Drawing.Point(95, 363);
            this.LblKeven.Name = "LblKeven";
            this.LblKeven.Size = new System.Drawing.Size(91, 13);
            this.LblKeven.TabIndex = 6;
            this.LblKeven.Text = "© Keven Baraúna";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(2, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(280, 138);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblAno.Location = new System.Drawing.Point(252, 445);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(20, 7);
            this.LblAno.TabIndex = 8;
            this.LblAno.Text = "2020";
            // 
            // ImgUsuario
            // 
            this.ImgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ImgUsuario.Image")));
            this.ImgUsuario.Location = new System.Drawing.Point(57, 200);
            this.ImgUsuario.Name = "ImgUsuario";
            this.ImgUsuario.Size = new System.Drawing.Size(24, 40);
            this.ImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgUsuario.TabIndex = 9;
            this.ImgUsuario.TabStop = false;
            // 
            // ImgSenha
            // 
            this.ImgSenha.Image = ((System.Drawing.Image)(resources.GetObject("ImgSenha.Image")));
            this.ImgSenha.Location = new System.Drawing.Point(55, 251);
            this.ImgSenha.Name = "ImgSenha";
            this.ImgSenha.Size = new System.Drawing.Size(24, 28);
            this.ImgSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgSenha.TabIndex = 10;
            this.ImgSenha.TabStop = false;
            // 
            // Linha
            // 
            this.Linha.BackColor = System.Drawing.Color.Orange;
            this.Linha.Location = new System.Drawing.Point(88, 230);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(130, 1);
            this.Linha.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(88, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1);
            this.panel1.TabIndex = 13;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(98, 330);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(84, 30);
            this.BtnEntrar.TabIndex = 14;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.ImgSenha);
            this.Controls.Add(this.ImgUsuario);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.LblKeven);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblKeven;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.PictureBox ImgUsuario;
        private System.Windows.Forms.PictureBox ImgSenha;
        private System.Windows.Forms.Panel Linha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEntrar;
    }
}

