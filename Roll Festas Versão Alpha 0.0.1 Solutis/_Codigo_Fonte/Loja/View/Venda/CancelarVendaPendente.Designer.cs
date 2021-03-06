﻿namespace Loja.View.Venda
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
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.LBITEM = new System.Windows.Forms.ListBox();
            this.LblTestedata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvPesquisa = new System.Windows.Forms.ListView();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(285, 399);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(89, 35);
            this.BtnFinalizar.TabIndex = 98;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(435, 72);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(90, 31);
            this.BtnPesquisar.TabIndex = 97;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnLimpar.Location = new System.Drawing.Point(43, 399);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(101, 35);
            this.BtnLimpar.TabIndex = 96;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(442, 26);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 95;
            this.LblUsuario.Text = "Usuário";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionar.Location = new System.Drawing.Point(54, 71);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(81, 32);
            this.BtnAdicionar.TabIndex = 94;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // LBITEM
            // 
            this.LBITEM.FormattingEnabled = true;
            this.LBITEM.Location = new System.Drawing.Point(19, 118);
            this.LBITEM.Name = "LBITEM";
            this.LBITEM.Size = new System.Drawing.Size(156, 264);
            this.LBITEM.TabIndex = 93;
            // 
            // LblTestedata
            // 
            this.LblTestedata.AutoSize = true;
            this.LblTestedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestedata.Location = new System.Drawing.Point(444, 51);
            this.LblTestedata.Name = "LblTestedata";
            this.LblTestedata.Size = new System.Drawing.Size(33, 15);
            this.LblTestedata.TabIndex = 91;
            this.LblTestedata.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Pesquisar vendas pendentes:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(105, 16);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(70, 20);
            this.TxtId.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Código da venda:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor pendente:";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data:";
            this.columnHeader3.Width = 80;
            // 
            // LvPesquisa
            // 
            this.LvPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1});
            this.LvPesquisa.HideSelection = false;
            this.LvPesquisa.Location = new System.Drawing.Point(204, 118);
            this.LvPesquisa.Name = "LvPesquisa";
            this.LvPesquisa.Size = new System.Drawing.Size(321, 264);
            this.LvPesquisa.TabIndex = 101;
            this.LvPesquisa.UseCompatibleStateImageBehavior = false;
            this.LvPesquisa.View = System.Windows.Forms.View.Details;
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(527, 8);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 102;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome:";
            this.columnHeader1.Width = 80;
            // 
            // CancelarVendaPendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.LvPesquisa);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.LBITEM);
            this.Controls.Add(this.LblTestedata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelarVendaPendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelarVendaPendente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.ListBox LBITEM;
        private System.Windows.Forms.Label LblTestedata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView LvPesquisa;
        private System.Windows.Forms.Button BtnDuvida;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}