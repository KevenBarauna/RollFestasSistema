namespace Loja.View.Caixa
{
    partial class VerCaixaPorData
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewUs = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Digite o número do mês:";
            // 
            // TxtAnoPesquisa
            // 
            this.TxtAnoPesquisa.Location = new System.Drawing.Point(256, 54);
            this.TxtAnoPesquisa.Name = "TxtAnoPesquisa";
            this.TxtAnoPesquisa.Size = new System.Drawing.Size(127, 20);
            this.TxtAnoPesquisa.TabIndex = 11;
            this.TxtAnoPesquisa.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ver fechamento";
            // 
            // listViewUs
            // 
            this.listViewUs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.H1,
            this.H2,
            this.H3,
            this.H4});
            this.listViewUs.HideSelection = false;
            this.listViewUs.Location = new System.Drawing.Point(12, 123);
            this.listViewUs.Name = "listViewUs";
            this.listViewUs.Size = new System.Drawing.Size(504, 302);
            this.listViewUs.TabIndex = 9;
            this.listViewUs.UseCompatibleStateImageBehavior = false;
            this.listViewUs.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Id:";
            this.Nome.Width = 100;
            // 
            // H1
            // 
            this.H1.Text = "Dia:";
            this.H1.Width = 100;
            // 
            // H2
            // 
            this.H2.Text = "Valor Total:";
            this.H2.Width = 100;
            // 
            // H3
            // 
            this.H3.Text = "Retirada";
            this.H3.Width = 100;
            // 
            // H4
            // 
            this.H4.Text = "Deposito";
            this.H4.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(219, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerCaixaPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAnoPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUs);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerCaixaPorData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerCaixaPorData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewUs;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader H1;
        private System.Windows.Forms.ColumnHeader H2;
        private System.Windows.Forms.ColumnHeader H3;
        private System.Windows.Forms.ColumnHeader H4;
        private System.Windows.Forms.Button button1;
    }
}