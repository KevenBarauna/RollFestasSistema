namespace Loja.View.Ponto
{
    partial class VerPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPonto));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewUs = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnoPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.TxtMes = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMes = new System.Windows.Forms.Button();
            this.TxtAno = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ver todos os pontos";
            // 
            // listViewUs
            // 
            this.listViewUs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.H1,
            this.H2,
            this.H3,
            this.H4,
            this.dia});
            this.listViewUs.HideSelection = false;
            this.listViewUs.Location = new System.Drawing.Point(12, 146);
            this.listViewUs.Name = "listViewUs";
            this.listViewUs.Size = new System.Drawing.Size(627, 283);
            this.listViewUs.TabIndex = 4;
            this.listViewUs.UseCompatibleStateImageBehavior = false;
            this.listViewUs.View = System.Windows.Forms.View.Details;
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
            this.H3.Text = "Volta do almoço";
            this.H3.Width = 100;
            // 
            // H4
            // 
            this.H4.Text = "Saída";
            this.H4.Width = 100;
            // 
            // dia
            // 
            this.dia.Text = "Data:";
            this.dia.Width = 120;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(123, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pesquisar por data";
            // 
            // TxtAnoPesquisa
            // 
            this.TxtAnoPesquisa.Location = new System.Drawing.Point(123, 88);
            this.TxtAnoPesquisa.Mask = "00/00/0000";
            this.TxtAnoPesquisa.Name = "TxtAnoPesquisa";
            this.TxtAnoPesquisa.Size = new System.Drawing.Size(88, 20);
            this.TxtAnoPesquisa.TabIndex = 8;
            this.TxtAnoPesquisa.ValidatingType = typeof(System.DateTime);
            // 
            // TxtMes
            // 
            this.TxtMes.Location = new System.Drawing.Point(273, 88);
            this.TxtMes.Mask = "00/0000";
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(88, 20);
            this.TxtMes.TabIndex = 11;
            this.TxtMes.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pesquisar por mês";
            // 
            // BtnMes
            // 
            this.BtnMes.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnMes.ForeColor = System.Drawing.Color.White;
            this.BtnMes.Location = new System.Drawing.Point(273, 114);
            this.BtnMes.Name = "BtnMes";
            this.BtnMes.Size = new System.Drawing.Size(88, 26);
            this.BtnMes.TabIndex = 9;
            this.BtnMes.Text = "Pesquisar";
            this.BtnMes.UseVisualStyleBackColor = false;
            this.BtnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(426, 88);
            this.TxtAno.Mask = "0000";
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(88, 20);
            this.TxtAno.TabIndex = 14;
            this.TxtAno.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pesquisar por ano";
            // 
            // BtnAno
            // 
            this.BtnAno.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnAno.ForeColor = System.Drawing.Color.White;
            this.BtnAno.Location = new System.Drawing.Point(426, 114);
            this.BtnAno.Name = "BtnAno";
            this.BtnAno.Size = new System.Drawing.Size(88, 26);
            this.BtnAno.TabIndex = 12;
            this.BtnAno.Text = "Pesquisar";
            this.BtnAno.UseVisualStyleBackColor = false;
            this.BtnAno.Click += new System.EventHandler(this.BtnAno_Click);
            // 
            // VerPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAno);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnMes);
            this.Controls.Add(this.TxtAnoPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUs);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerPonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewUs;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader H1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader H2;
        private System.Windows.Forms.ColumnHeader H3;
        private System.Windows.Forms.ColumnHeader H4;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtAnoPesquisa;
        private System.Windows.Forms.MaskedTextBox TxtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMes;
        private System.Windows.Forms.MaskedTextBox TxtAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAno;
    }
}