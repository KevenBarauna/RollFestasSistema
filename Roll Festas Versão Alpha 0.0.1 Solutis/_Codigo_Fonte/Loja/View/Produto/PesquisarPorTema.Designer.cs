namespace Loja.View.Produto
{
    partial class PesquisarPorTema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarPorTema));
            this.TxtTema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.LVPesquisa = new System.Windows.Forms.ListView();
            this.CID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPRECO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TxtTema
            // 
            this.TxtTema.Location = new System.Drawing.Point(29, 76);
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.Size = new System.Drawing.Size(128, 20);
            this.TxtTema.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Digite o tema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pesquisar produto por tema:";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(168, 64);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(81, 32);
            this.BtnPesquisar.TabIndex = 43;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // LVPesquisa
            // 
            this.LVPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CID,
            this.CNOME,
            this.CPRECO});
            this.LVPesquisa.HideSelection = false;
            this.LVPesquisa.Location = new System.Drawing.Point(15, 112);
            this.LVPesquisa.Name = "LVPesquisa";
            this.LVPesquisa.Size = new System.Drawing.Size(257, 326);
            this.LVPesquisa.TabIndex = 44;
            this.LVPesquisa.UseCompatibleStateImageBehavior = false;
            this.LVPesquisa.View = System.Windows.Forms.View.Details;
            // 
            // CID
            // 
            this.CID.Text = "Código";
            this.CID.Width = 55;
            // 
            // CNOME
            // 
            this.CNOME.Text = "Nome";
            this.CNOME.Width = 110;
            // 
            // CPRECO
            // 
            this.CPRECO.Text = "Preço";
            this.CPRECO.Width = 81;
            // 
            // PesquisarPorTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.LVPesquisa);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxtTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisarPorTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarPorTema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.ListView LVPesquisa;
        private System.Windows.Forms.ColumnHeader CID;
        private System.Windows.Forms.ColumnHeader CNOME;
        private System.Windows.Forms.ColumnHeader CPRECO;
    }
}