namespace RollFestas.View.Mercadoria
{
    partial class NovaMercadoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaMercadoria));
            this.Linha = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.Txtpreco = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.TxtTema = new System.Windows.Forms.TextBox();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.CbQuant = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // Linha
            // 
            this.Linha.BackColor = System.Drawing.Color.Orange;
            this.Linha.Location = new System.Drawing.Point(13, 122);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(150, 1);
            this.Linha.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNome.Location = new System.Drawing.Point(12, 108);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(150, 13);
            this.TxtNome.TabIndex = 59;
            // 
            // Txtpreco
            // 
            this.Txtpreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtpreco.Location = new System.Drawing.Point(15, 153);
            this.Txtpreco.Name = "Txtpreco";
            this.Txtpreco.Size = new System.Drawing.Size(142, 13);
            this.Txtpreco.TabIndex = 67;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtQuantidade.Location = new System.Drawing.Point(242, 107);
            this.TxtQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(164, 16);
            this.TxtQuantidade.TabIndex = 66;
            // 
            // TxtTema
            // 
            this.TxtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTema.Location = new System.Drawing.Point(242, 155);
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.Size = new System.Drawing.Size(142, 13);
            this.TxtTema.TabIndex = 65;
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFornecedor.Location = new System.Drawing.Point(15, 209);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(142, 13);
            this.TxtFornecedor.TabIndex = 60;
            // 
            // TxtData
            // 
            this.TxtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtData.Location = new System.Drawing.Point(242, 209);
            this.TxtData.Mask = "00/00/0000";
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(142, 13);
            this.TxtData.TabIndex = 63;
            this.TxtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(27, 286);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(371, 83);
            this.txtDescricao.TabIndex = 61;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(15, 402);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(84, 28);
            this.BtnSalvar.TabIndex = 62;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Tema:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Data de chegada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "* Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "* Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Adicionar novo produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(13, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(234, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(236, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 73;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(13, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 74;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Location = new System.Drawing.Point(242, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 1);
            this.panel5.TabIndex = 75;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.Red;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.Location = new System.Drawing.Point(331, 402);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 29);
            this.BtnFechar.TabIndex = 76;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // CbQuant
            // 
            this.CbQuant.AutoSize = true;
            this.CbQuant.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CbQuant.Location = new System.Drawing.Point(298, 86);
            this.CbQuant.Name = "CbQuant";
            this.CbQuant.Size = new System.Drawing.Size(116, 17);
            this.CbQuant.TabIndex = 77;
            this.CbQuant.Text = "Não quero informar";
            this.CbQuant.UseVisualStyleBackColor = true;
            this.CbQuant.CheckedChanged += new System.EventHandler(this.CbQuant_CheckedChanged);
            // 
            // NovaMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 442);
            this.Controls.Add(this.CbQuant);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.Txtpreco);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.TxtTema);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovaMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova mercadoria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Linha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox Txtpreco;
        private System.Windows.Forms.NumericUpDown TxtQuantidade;
        private System.Windows.Forms.TextBox TxtTema;
        private System.Windows.Forms.TextBox TxtFornecedor;
        private System.Windows.Forms.MaskedTextBox TxtData;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.CheckBox CbQuant;
    }
}