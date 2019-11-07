namespace Loja.View.Recibo
{
    partial class ReciboPorId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciboPorId));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtData = new System.Windows.Forms.MaskedTextBox();
            this.listCodigo = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnVerVendas = new System.Windows.Forms.Button();
            this.BtnGerarPdf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a data venda:";
            // 
            // TxtData
            // 
            this.TxtData.Location = new System.Drawing.Point(193, 31);
            this.TxtData.Mask = "00/00/0000";
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(72, 20);
            this.TxtData.TabIndex = 1;
            this.TxtData.ValidatingType = typeof(System.DateTime);
            // 
            // listCodigo
            // 
            this.listCodigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listCodigo.HideSelection = false;
            this.listCodigo.Location = new System.Drawing.Point(15, 108);
            this.listCodigo.Name = "listCodigo";
            this.listCodigo.Size = new System.Drawing.Size(360, 316);
            this.listCodigo.TabIndex = 5;
            this.listCodigo.UseCompatibleStateImageBehavior = false;
            this.listCodigo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Código:";
            this.columnHeader7.Width = 55;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Valor Total:";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Valor pago:";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Troco:";
            this.columnHeader11.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite o código da venda:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(410, 140);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 7;
            // 
            // BtnVerVendas
            // 
            this.BtnVerVendas.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnVerVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVerVendas.Location = new System.Drawing.Point(139, 68);
            this.BtnVerVendas.Name = "BtnVerVendas";
            this.BtnVerVendas.Size = new System.Drawing.Size(81, 32);
            this.BtnVerVendas.TabIndex = 40;
            this.BtnVerVendas.Text = "Ver vendas";
            this.BtnVerVendas.UseVisualStyleBackColor = false;
            this.BtnVerVendas.Click += new System.EventHandler(this.BtnVerVendas_Click_1);
            // 
            // BtnGerarPdf
            // 
            this.BtnGerarPdf.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnGerarPdf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGerarPdf.Location = new System.Drawing.Point(410, 180);
            this.BtnGerarPdf.Name = "BtnGerarPdf";
            this.BtnGerarPdf.Size = new System.Drawing.Size(100, 35);
            this.BtnGerarPdf.TabIndex = 44;
            this.BtnGerarPdf.Text = "Gerar PDF";
            this.BtnGerarPdf.UseVisualStyleBackColor = false;
            this.BtnGerarPdf.Click += new System.EventHandler(this.BtnGerarPdf_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // ReciboPorId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGerarPdf);
            this.Controls.Add(this.BtnVerVendas);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCodigo);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReciboPorId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar recibo da venda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtData;
        private System.Windows.Forms.ListView listCodigo;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnVerVendas;
        private System.Windows.Forms.Button BtnGerarPdf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}