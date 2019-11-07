namespace Loja.View.Produto
{
    partial class ExibirProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExibirProdutos));
            this.listCodigo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.BtnData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAlfabetica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCodigo
            // 
            this.listCodigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listCodigo.HideSelection = false;
            this.listCodigo.Location = new System.Drawing.Point(12, 90);
            this.listCodigo.Name = "listCodigo";
            this.listCodigo.Size = new System.Drawing.Size(746, 337);
            this.listCodigo.TabIndex = 3;
            this.listCodigo.UseCompatibleStateImageBehavior = false;
            this.listCodigo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome:";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tema:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preço:";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade:";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fornecedor:";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Descrição:";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data:";
            this.columnHeader7.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Exibir por data:";
            // 
            // BtnData
            // 
            this.BtnData.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnData.ForeColor = System.Drawing.Color.White;
            this.BtnData.Location = new System.Drawing.Point(421, 48);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(88, 26);
            this.BtnData.TabIndex = 21;
            this.BtnData.Text = "Pesquisar";
            this.BtnData.UseVisualStyleBackColor = false;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Exibir por odem alfabética";
            // 
            // BtnAlfabetica
            // 
            this.BtnAlfabetica.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnAlfabetica.ForeColor = System.Drawing.Color.White;
            this.BtnAlfabetica.Location = new System.Drawing.Point(275, 48);
            this.BtnAlfabetica.Name = "BtnAlfabetica";
            this.BtnAlfabetica.Size = new System.Drawing.Size(88, 26);
            this.BtnAlfabetica.TabIndex = 18;
            this.BtnAlfabetica.Text = "Pesquisar";
            this.BtnAlfabetica.UseVisualStyleBackColor = false;
            this.BtnAlfabetica.Click += new System.EventHandler(this.BtnAlfabetica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Exibir po código:";
            // 
            // BtnCodigo
            // 
            this.BtnCodigo.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCodigo.ForeColor = System.Drawing.Color.White;
            this.BtnCodigo.Location = new System.Drawing.Point(124, 48);
            this.BtnCodigo.Name = "BtnCodigo";
            this.BtnCodigo.Size = new System.Drawing.Size(88, 26);
            this.BtnCodigo.TabIndex = 15;
            this.BtnCodigo.Text = "Pesquisar";
            this.BtnCodigo.UseVisualStyleBackColor = false;
            this.BtnCodigo.Click += new System.EventHandler(this.BtnCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Exibir por tema:";
            // 
            // BtnTema
            // 
            this.BtnTema.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnTema.ForeColor = System.Drawing.Color.White;
            this.BtnTema.Location = new System.Drawing.Point(557, 48);
            this.BtnTema.Name = "BtnTema";
            this.BtnTema.Size = new System.Drawing.Size(88, 26);
            this.BtnTema.TabIndex = 23;
            this.BtnTema.Text = "Pesquisar";
            this.BtnTema.UseVisualStyleBackColor = false;
            this.BtnTema.Click += new System.EventHandler(this.BtnTema_Click);
            // 
            // ExibirProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAlfabetica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCodigo);
            this.Controls.Add(this.listCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExibirProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExibirProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCodigo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAlfabetica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTema;
    }
}