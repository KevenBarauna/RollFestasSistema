namespace RollFestas.View.Venda
{
    partial class PesquisarDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarDia));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.listCodigo = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorPendente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImgProximasEncomendas = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPesquisaData = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnPesquisarData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(721, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 56;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(756, 12);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 54;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            // 
            // listCodigo
            // 
            this.listCodigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Usuario,
            this.ValorTotal,
            this.ValorPago,
            this.TipoPagamento,
            this.StatusPagamento,
            this.ValorPendente,
            this.NomeCliente});
            this.listCodigo.HideSelection = false;
            this.listCodigo.Location = new System.Drawing.Point(12, 146);
            this.listCodigo.Name = "listCodigo";
            this.listCodigo.Size = new System.Drawing.Size(779, 279);
            this.listCodigo.TabIndex = 52;
            this.listCodigo.UseCompatibleStateImageBehavior = false;
            this.listCodigo.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Código:";
            this.Id.Width = 50;
            // 
            // Data
            // 
            this.Data.Text = "Data:";
            this.Data.Width = 70;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuário";
            this.Usuario.Width = 80;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor total:";
            this.ValorTotal.Width = 100;
            // 
            // ValorPago
            // 
            this.ValorPago.Text = "valor pago:";
            this.ValorPago.Width = 100;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.Text = "Pagamento:";
            this.TipoPagamento.Width = 100;
            // 
            // StatusPagamento
            // 
            this.StatusPagamento.Text = "Status";
            // 
            // ValorPendente
            // 
            this.ValorPendente.Text = "Valor pendente:";
            this.ValorPendente.Width = 100;
            // 
            // NomeCliente
            // 
            this.NomeCliente.Text = "Nome cliente:";
            this.NomeCliente.Width = 110;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.ImgProximasEncomendas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 52);
            this.panel3.TabIndex = 57;
            // 
            // ImgProximasEncomendas
            // 
            this.ImgProximasEncomendas.Image = ((System.Drawing.Image)(resources.GetObject("ImgProximasEncomendas.Image")));
            this.ImgProximasEncomendas.Location = new System.Drawing.Point(26, 0);
            this.ImgProximasEncomendas.Name = "ImgProximasEncomendas";
            this.ImgProximasEncomendas.Size = new System.Drawing.Size(55, 46);
            this.ImgProximasEncomendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgProximasEncomendas.TabIndex = 30;
            this.ImgProximasEncomendas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Amiri Quran", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 54);
            this.label3.TabIndex = 27;
            this.label3.Text = "Essas são as vendas:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPesquisaData
            // 
            this.TxtPesquisaData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPesquisaData.Location = new System.Drawing.Point(330, 30);
            this.TxtPesquisaData.Name = "TxtPesquisaData";
            this.TxtPesquisaData.Size = new System.Drawing.Size(155, 13);
            this.TxtPesquisaData.TabIndex = 175;
            this.TxtPesquisaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Location = new System.Drawing.Point(333, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 1);
            this.panel7.TabIndex = 174;
            // 
            // BtnPesquisarData
            // 
            this.BtnPesquisarData.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarData.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisarData.Location = new System.Drawing.Point(360, 53);
            this.BtnPesquisarData.Name = "BtnPesquisarData";
            this.BtnPesquisarData.Size = new System.Drawing.Size(89, 27);
            this.BtnPesquisarData.TabIndex = 177;
            this.BtnPesquisarData.Text = "Pesquisar";
            this.BtnPesquisarData.UseVisualStyleBackColor = false;
            this.BtnPesquisarData.Click += new System.EventHandler(this.BtnPesquisarData_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 176;
            this.label10.Text = "Venda por data";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(392, 11);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 13);
            this.LblId.TabIndex = 173;
            // 
            // PesquisarDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 472);
            this.Controls.Add(this.TxtPesquisaData);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.BtnPesquisarData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.listCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarDia";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDuvida;
        private System.Windows.Forms.ListView listCodigo;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.ColumnHeader ValorPago;
        private System.Windows.Forms.ColumnHeader TipoPagamento;
        private System.Windows.Forms.ColumnHeader StatusPagamento;
        private System.Windows.Forms.ColumnHeader ValorPendente;
        private System.Windows.Forms.ColumnHeader NomeCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgProximasEncomendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPesquisaData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnPesquisarData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblId;
    }
}