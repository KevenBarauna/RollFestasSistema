namespace Loja.View.Venda
{
    partial class Devolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucao));
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.TxtNumQuant = new System.Windows.Forms.NumericUpDown();
            this.LBITEM = new System.Windows.Forms.ListBox();
            this.LblTestedata = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LVPesquisa = new System.Windows.Forms.ListView();
            this.CID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDatVenda = new System.Windows.Forms.MaskedTextBox();
            this.BtnDuvida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(411, 341);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(95, 29);
            this.BtnFinalizar.TabIndex = 90;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(260, 80);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(90, 31);
            this.BtnPesquisar.TabIndex = 89;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnLimpar.Location = new System.Drawing.Point(48, 387);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(101, 35);
            this.BtnLimpar.TabIndex = 88;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(419, 19);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 87;
            this.LblUsuario.Text = "Usuário";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionar.Location = new System.Drawing.Point(48, 149);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(81, 32);
            this.BtnAdicionar.TabIndex = 86;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // TxtNumQuant
            // 
            this.TxtNumQuant.Location = new System.Drawing.Point(130, 112);
            this.TxtNumQuant.Name = "TxtNumQuant";
            this.TxtNumQuant.Size = new System.Drawing.Size(56, 20);
            this.TxtNumQuant.TabIndex = 85;
            this.TxtNumQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBITEM
            // 
            this.LBITEM.FormattingEnabled = true;
            this.LBITEM.Location = new System.Drawing.Point(24, 197);
            this.LBITEM.Name = "LBITEM";
            this.LBITEM.Size = new System.Drawing.Size(156, 173);
            this.LBITEM.TabIndex = 84;
            // 
            // LblTestedata
            // 
            this.LblTestedata.AutoSize = true;
            this.LblTestedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestedata.Location = new System.Drawing.Point(419, 50);
            this.LblTestedata.Name = "LblTestedata";
            this.LblTestedata.Size = new System.Drawing.Size(33, 15);
            this.LblTestedata.TabIndex = 83;
            this.LblTestedata.Text = "Data";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(411, 184);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Total:";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(228, 45);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(159, 20);
            this.TxtPesquisa.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Pesquisar produto por nome:";
            // 
            // LVPesquisa
            // 
            this.LVPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CID,
            this.CNOME});
            this.LVPesquisa.HideSelection = false;
            this.LVPesquisa.Location = new System.Drawing.Point(228, 127);
            this.LVPesquisa.Name = "LVPesquisa";
            this.LVPesquisa.Size = new System.Drawing.Size(159, 243);
            this.LVPesquisa.TabIndex = 76;
            this.LVPesquisa.UseCompatibleStateImageBehavior = false;
            this.LVPesquisa.View = System.Windows.Forms.View.Details;
            // 
            // CID
            // 
            this.CID.Text = "ID";
            this.CID.Width = 45;
            // 
            // CNOME
            // 
            this.CNOME.Text = "Nome";
            this.CNOME.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Quantidade devolvida:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(118, 86);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(68, 20);
            this.TxtId.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Código do produto:";
            // 
            // TxtCodigoVenda
            // 
            this.TxtCodigoVenda.Location = new System.Drawing.Point(118, 45);
            this.TxtCodigoVenda.Name = "TxtCodigoVenda";
            this.TxtCodigoVenda.Size = new System.Drawing.Size(68, 20);
            this.TxtCodigoVenda.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Código da venda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Data da venda:";
            // 
            // TxtDatVenda
            // 
            this.TxtDatVenda.Location = new System.Drawing.Point(118, 19);
            this.TxtDatVenda.Mask = "00/00/0000";
            this.TxtDatVenda.Name = "TxtDatVenda";
            this.TxtDatVenda.Size = new System.Drawing.Size(68, 20);
            this.TxtDatVenda.TabIndex = 94;
            this.TxtDatVenda.ValidatingType = typeof(System.DateTime);
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(489, 2);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 95;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.TxtDatVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCodigoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtNumQuant);
            this.Controls.Add(this.LBITEM);
            this.Controls.Add(this.LblTestedata);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LVPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucao";
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.NumericUpDown TxtNumQuant;
        private System.Windows.Forms.ListBox LBITEM;
        private System.Windows.Forms.Label LblTestedata;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView LVPesquisa;
        private System.Windows.Forms.ColumnHeader CID;
        private System.Windows.Forms.ColumnHeader CNOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TxtDatVenda;
        private System.Windows.Forms.Button BtnDuvida;
    }
}