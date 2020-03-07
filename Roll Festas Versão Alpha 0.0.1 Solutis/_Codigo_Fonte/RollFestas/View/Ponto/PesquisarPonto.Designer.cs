namespace RollFestas.View.Ponto
{
    partial class PesquisarPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarPonto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Linha = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtMes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMes = new System.Windows.Forms.Button();
            this.TxtDataPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPonto = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(306, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 1);
            this.panel1.TabIndex = 50;
            // 
            // Linha
            // 
            this.Linha.BackColor = System.Drawing.Color.Orange;
            this.Linha.Location = new System.Drawing.Point(156, 95);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(88, 1);
            this.Linha.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // TxtMes
            // 
            this.TxtMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMes.Location = new System.Drawing.Point(306, 78);
            this.TxtMes.Mask = "00/0000";
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(88, 13);
            this.TxtMes.TabIndex = 44;
            this.TxtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMes.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pesquisar por mês";
            // 
            // BtnMes
            // 
            this.BtnMes.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMes.ForeColor = System.Drawing.Color.White;
            this.BtnMes.Location = new System.Drawing.Point(306, 106);
            this.BtnMes.Name = "BtnMes";
            this.BtnMes.Size = new System.Drawing.Size(88, 26);
            this.BtnMes.TabIndex = 42;
            this.BtnMes.Text = "Pesquisar";
            this.BtnMes.UseVisualStyleBackColor = false;
            this.BtnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // TxtDataPesquisa
            // 
            this.TxtDataPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDataPesquisa.Location = new System.Drawing.Point(156, 78);
            this.TxtDataPesquisa.Mask = "00/00/0000";
            this.TxtDataPesquisa.Name = "TxtDataPesquisa";
            this.TxtDataPesquisa.Size = new System.Drawing.Size(88, 13);
            this.TxtDataPesquisa.TabIndex = 41;
            this.TxtDataPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDataPesquisa.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Pesquisar por data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ver todos os pontos";
            // 
            // listViewPonto
            // 
            this.listViewPonto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.dia,
            this.H1,
            this.H2,
            this.H3,
            this.H4});
            this.listViewPonto.HideSelection = false;
            this.listViewPonto.Location = new System.Drawing.Point(25, 155);
            this.listViewPonto.Name = "listViewPonto";
            this.listViewPonto.Size = new System.Drawing.Size(627, 283);
            this.listViewPonto.TabIndex = 38;
            this.listViewPonto.UseCompatibleStateImageBehavior = false;
            this.listViewPonto.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome:";
            this.Nome.Width = 100;
            // 
            // H1
            // 
            this.H1.Text = "Chegada:";
            this.H1.Width = 100;
            // 
            // H2
            // 
            this.H2.Text = "Saida do almoço";
            this.H2.Width = 100;
            // 
            // H3
            // 
            this.H3.Text = "Chegada do almoço";
            this.H3.Width = 120;
            // 
            // H4
            // 
            this.H4.Text = "Saída";
            this.H4.Width = 100;
            // 
            // dia
            // 
            this.dia.Text = "Data:";
            this.dia.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(156, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 37;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(590, 450);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(70, 30);
            this.BtnSair.TabIndex = 51;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PesquisarPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 492);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnMes);
            this.Controls.Add(this.TxtDataPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPonto);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarPonto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Linha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox TxtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMes;
        private System.Windows.Forms.MaskedTextBox TxtDataPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewPonto;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader H1;
        private System.Windows.Forms.ColumnHeader H2;
        private System.Windows.Forms.ColumnHeader H3;
        private System.Windows.Forms.ColumnHeader H4;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSair;
    }
}