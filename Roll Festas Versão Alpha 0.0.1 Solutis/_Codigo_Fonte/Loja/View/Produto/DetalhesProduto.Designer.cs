namespace Loja.View.Produto
{
    partial class DetalhesProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesProduto));
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisaCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.TxtData = new System.Windows.Forms.TextBox();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtTema = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(173, 81);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(84, 33);
            this.BtnPesquisar.TabIndex = 17;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digite o código do produto";
            // 
            // txtPesquisaCodigo
            // 
            this.txtPesquisaCodigo.Location = new System.Drawing.Point(133, 55);
            this.txtPesquisaCodigo.Name = "txtPesquisaCodigo";
            this.txtPesquisaCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtPesquisaCodigo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Detalhes do produto";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescricao.Location = new System.Drawing.Point(12, 305);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(390, 85);
            this.txtDescricao.TabIndex = 31;
            // 
            // TxtData
            // 
            this.TxtData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtData.Location = new System.Drawing.Point(305, 209);
            this.TxtData.MaxLength = 10;
            this.TxtData.Name = "TxtData";
            this.TxtData.ReadOnly = true;
            this.TxtData.Size = new System.Drawing.Size(97, 20);
            this.TxtData.TabIndex = 30;
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtFornecedor.Location = new System.Drawing.Point(283, 171);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.ReadOnly = true;
            this.TxtFornecedor.Size = new System.Drawing.Size(119, 20);
            this.TxtFornecedor.TabIndex = 29;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtQuantidade.Location = new System.Drawing.Point(95, 206);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.ReadOnly = true;
            this.TxtQuantidade.Size = new System.Drawing.Size(84, 20);
            this.TxtQuantidade.TabIndex = 28;
            // 
            // TxtPreco
            // 
            this.TxtPreco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtPreco.Location = new System.Drawing.Point(95, 171);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.ReadOnly = true;
            this.TxtPreco.Size = new System.Drawing.Size(84, 20);
            this.TxtPreco.TabIndex = 27;
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtNome.Location = new System.Drawing.Point(260, 133);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.ReadOnly = true;
            this.TxtNome.Size = new System.Drawing.Size(142, 20);
            this.TxtNome.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data de chegada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "*Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "*Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "*Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(95, 133);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(84, 20);
            this.TxtCodigo.TabIndex = 33;
            // 
            // TxtTema
            // 
            this.TxtTema.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTema.Location = new System.Drawing.Point(95, 239);
            this.TxtTema.MaxLength = 10;
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.ReadOnly = true;
            this.TxtTema.Size = new System.Drawing.Size(84, 20);
            this.TxtTema.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tema:";
            // 
            // DetalhesProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 402);
            this.Controls.Add(this.TxtTema);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisaCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalhesProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisaCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.TextBox TxtFornecedor;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtTema;
        private System.Windows.Forms.Label label10;
    }
}