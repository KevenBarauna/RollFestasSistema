namespace RollFestas.View.Venda.PagamentoPendente
{
    partial class CancelarVendaPendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarVendaPendente));
            this.ListaVenda = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImgProximasEncomendas = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listCodigo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaVenda
            // 
            this.ListaVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5});
            this.ListaVenda.HideSelection = false;
            this.ListaVenda.Location = new System.Drawing.Point(12, 110);
            this.ListaVenda.Name = "ListaVenda";
            this.ListaVenda.Size = new System.Drawing.Size(214, 344);
            this.ListaVenda.TabIndex = 236;
            this.ListaVenda.UseCompatibleStateImageBehavior = false;
            this.ListaVenda.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cliente:";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor pendente:";
            this.columnHeader5.Width = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.ImgProximasEncomendas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(268, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 52);
            this.panel3.TabIndex = 235;
            // 
            // ImgProximasEncomendas
            // 
            this.ImgProximasEncomendas.Image = ((System.Drawing.Image)(resources.GetObject("ImgProximasEncomendas.Image")));
            this.ImgProximasEncomendas.Location = new System.Drawing.Point(3, 3);
            this.ImgProximasEncomendas.Name = "ImgProximasEncomendas";
            this.ImgProximasEncomendas.Size = new System.Drawing.Size(55, 46);
            this.ImgProximasEncomendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProximasEncomendas.TabIndex = 30;
            this.ImgProximasEncomendas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Amiri Quran", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pagamentos pendentes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listCodigo
            // 
            this.listCodigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader1});
            this.listCodigo.HideSelection = false;
            this.listCodigo.Location = new System.Drawing.Point(268, 85);
            this.listCodigo.Name = "listCodigo";
            this.listCodigo.Size = new System.Drawing.Size(283, 369);
            this.listCodigo.TabIndex = 234;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome:";
            this.columnHeader1.Width = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 233;
            this.pictureBox1.TabStop = false;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(164, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(62, 20);
            this.TxtId.TabIndex = 231;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionar.Location = new System.Drawing.Point(12, 72);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(214, 32);
            this.BtnAdicionar.TabIndex = 232;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 230;
            this.label1.Text = "Código da venda:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(241, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 447);
            this.panel2.TabIndex = 229;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(577, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 447);
            this.panel1.TabIndex = 228;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Red;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.Cancelar.Location = new System.Drawing.Point(644, 419);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(92, 35);
            this.Cancelar.TabIndex = 220;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(601, 367);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 219;
            this.pictureBox10.TabStop = false;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(644, 367);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(92, 35);
            this.BtnFinalizar.TabIndex = 218;
            this.BtnFinalizar.Text = "Cancelar venda";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(591, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 209;
            this.pictureBox3.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(641, 24);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(56, 16);
            this.LblUsuario.TabIndex = 208;
            this.LblUsuario.Text = "Usuário";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblData.Location = new System.Drawing.Point(641, 44);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(33, 15);
            this.LblData.TabIndex = 207;
            this.LblData.Text = "Data";
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(591, 85);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 206;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            // 
            // CancelarVendaPendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 477);
            this.Controls.Add(this.ListaVenda);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.BtnDuvida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CancelarVendaPendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelarVendaPendente";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaVenda;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgProximasEncomendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listCodigo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Button BtnDuvida;
    }
}