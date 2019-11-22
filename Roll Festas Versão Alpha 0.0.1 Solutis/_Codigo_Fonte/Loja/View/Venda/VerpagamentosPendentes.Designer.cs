namespace Loja.View.Venda
{
    partial class VerpagamentosPendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerpagamentosPendentes));
            this.listCodigo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listCodigo
            // 
            this.listCodigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1});
            this.listCodigo.HideSelection = false;
            this.listCodigo.Location = new System.Drawing.Point(27, 53);
            this.listCodigo.Name = "listCodigo";
            this.listCodigo.Size = new System.Drawing.Size(384, 369);
            this.listCodigo.TabIndex = 4;
            this.listCodigo.UseCompatibleStateImageBehavior = false;
            this.listCodigo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código venda:";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor pendente:";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data:";
            this.columnHeader3.Width = 100;
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(366, 12);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 49;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Esses são todos os seus pagamentos pendentes:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome:";
            this.columnHeader1.Width = 90;
            // 
            // VerpagamentosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.listCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerpagamentosPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerpagamentosPendentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCodigo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnDuvida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}