namespace RollFestas.View.Caixa
{
    partial class Faturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faturamento));
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImgProximasEncomendas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListViewCaixa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPesquisaMes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPesquisarMes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPesquisaData = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnPesquisarData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPesquisaHoje = new System.Windows.Forms.TextBox();
            this.BtnPesquisarHoje = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPesquisaAno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPesquisarAno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.ImgProximasEncomendas);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(66, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 52);
            this.panel3.TabIndex = 163;
            // 
            // ImgProximasEncomendas
            // 
            this.ImgProximasEncomendas.Image = ((System.Drawing.Image)(resources.GetObject("ImgProximasEncomendas.Image")));
            this.ImgProximasEncomendas.Location = new System.Drawing.Point(39, 3);
            this.ImgProximasEncomendas.Name = "ImgProximasEncomendas";
            this.ImgProximasEncomendas.Size = new System.Drawing.Size(55, 46);
            this.ImgProximasEncomendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProximasEncomendas.TabIndex = 30;
            this.ImgProximasEncomendas.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Amiri Quran", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 54);
            this.label4.TabIndex = 27;
            this.label4.Text = "Detalhes do caixa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListViewCaixa
            // 
            this.ListViewCaixa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewCaixa.HideSelection = false;
            this.ListViewCaixa.Location = new System.Drawing.Point(67, 165);
            this.ListViewCaixa.Name = "ListViewCaixa";
            this.ListViewCaixa.Size = new System.Drawing.Size(758, 314);
            this.ListViewCaixa.TabIndex = 162;
            this.ListViewCaixa.UseCompatibleStateImageBehavior = false;
            this.ListViewCaixa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código:";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valor total:";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data:";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Retirada:";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Deposito:";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dinheiro:";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cartão:";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Outros:";
            this.columnHeader4.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(448, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 161;
            this.label3.Text = "ou";
            // 
            // TxtPesquisaMes
            // 
            this.TxtPesquisaMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPesquisaMes.Location = new System.Drawing.Point(496, 31);
            this.TxtPesquisaMes.Name = "TxtPesquisaMes";
            this.TxtPesquisaMes.Size = new System.Drawing.Size(155, 13);
            this.TxtPesquisaMes.TabIndex = 158;
            this.TxtPesquisaMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(499, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 157;
            // 
            // BtnPesquisarMes
            // 
            this.BtnPesquisarMes.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisarMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarMes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisarMes.Location = new System.Drawing.Point(526, 54);
            this.BtnPesquisarMes.Name = "BtnPesquisarMes";
            this.BtnPesquisarMes.Size = new System.Drawing.Size(89, 27);
            this.BtnPesquisarMes.TabIndex = 160;
            this.BtnPesquisarMes.Text = "Pesquisar";
            this.BtnPesquisarMes.UseVisualStyleBackColor = false;
            this.BtnPesquisarMes.Click += new System.EventHandler(this.BtnPesquisarMes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(518, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 159;
            this.label2.Text = "Faturamento por mês";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(209, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 156;
            this.label11.Text = "ou";
            // 
            // TxtPesquisaData
            // 
            this.TxtPesquisaData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPesquisaData.Location = new System.Drawing.Point(264, 31);
            this.TxtPesquisaData.Name = "TxtPesquisaData";
            this.TxtPesquisaData.Size = new System.Drawing.Size(155, 13);
            this.TxtPesquisaData.TabIndex = 153;
            this.TxtPesquisaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Location = new System.Drawing.Point(267, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 1);
            this.panel7.TabIndex = 152;
            // 
            // BtnPesquisarData
            // 
            this.BtnPesquisarData.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarData.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisarData.Location = new System.Drawing.Point(294, 54);
            this.BtnPesquisarData.Name = "BtnPesquisarData";
            this.BtnPesquisarData.Size = new System.Drawing.Size(89, 27);
            this.BtnPesquisarData.TabIndex = 155;
            this.BtnPesquisarData.Text = "Pesquisar";
            this.BtnPesquisarData.UseVisualStyleBackColor = false;
            this.BtnPesquisarData.Click += new System.EventHandler(this.BtnPesquisarData_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(284, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "Faturamento por data";
            // 
            // txtPesquisaHoje
            // 
            this.txtPesquisaHoje.BackColor = System.Drawing.Color.White;
            this.txtPesquisaHoje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaHoje.Location = new System.Drawing.Point(31, 31);
            this.txtPesquisaHoje.Name = "txtPesquisaHoje";
            this.txtPesquisaHoje.ReadOnly = true;
            this.txtPesquisaHoje.Size = new System.Drawing.Size(155, 13);
            this.txtPesquisaHoje.TabIndex = 148;
            this.txtPesquisaHoje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPesquisarHoje
            // 
            this.BtnPesquisarHoje.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisarHoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarHoje.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisarHoje.Location = new System.Drawing.Point(61, 54);
            this.BtnPesquisarHoje.Name = "BtnPesquisarHoje";
            this.BtnPesquisarHoje.Size = new System.Drawing.Size(89, 27);
            this.BtnPesquisarHoje.TabIndex = 150;
            this.BtnPesquisarHoje.Text = "Pesquisar";
            this.BtnPesquisarHoje.UseVisualStyleBackColor = false;
            this.BtnPesquisarHoje.Click += new System.EventHandler(this.BtnPesquisarHoje_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(58, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "Faturamento hoje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(658, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 168;
            this.label1.Text = "ou";
            // 
            // TxtPesquisaAno
            // 
            this.TxtPesquisaAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPesquisaAno.Location = new System.Drawing.Point(706, 31);
            this.TxtPesquisaAno.Name = "TxtPesquisaAno";
            this.TxtPesquisaAno.Size = new System.Drawing.Size(155, 13);
            this.TxtPesquisaAno.TabIndex = 165;
            this.TxtPesquisaAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(709, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 164;
            // 
            // BtnPesquisarAno
            // 
            this.BtnPesquisarAno.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisarAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarAno.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisarAno.Location = new System.Drawing.Point(736, 54);
            this.BtnPesquisarAno.Name = "BtnPesquisarAno";
            this.BtnPesquisarAno.Size = new System.Drawing.Size(89, 27);
            this.BtnPesquisarAno.TabIndex = 167;
            this.BtnPesquisarAno.Text = "Pesquisar";
            this.BtnPesquisarAno.UseVisualStyleBackColor = false;
            this.BtnPesquisarAno.Click += new System.EventHandler(this.BtnPesquisarAno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(733, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 166;
            this.label5.Text = "Faturamento por ano";
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Location = new System.Drawing.Point(807, 499);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(70, 30);
            this.BtnFechar.TabIndex = 169;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // Faturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 541);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPesquisaAno);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnPesquisarAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ListViewCaixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPesquisaMes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnPesquisarMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPesquisaData);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.BtnPesquisarData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPesquisaHoje);
            this.Controls.Add(this.BtnPesquisarHoje);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Faturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturamento";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgProximasEncomendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListViewCaixa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPesquisaMes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPesquisarMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPesquisaData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnPesquisarData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPesquisaHoje;
        private System.Windows.Forms.Button BtnPesquisarHoje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPesquisaAno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPesquisarAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BtnFechar;
    }
}