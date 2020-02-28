namespace Loja.View.Venda
{
    partial class Troca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Troca));
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnAdicionarDevolvido = new System.Windows.Forms.Button();
            this.TxtNumQuantDevolvido = new System.Windows.Forms.NumericUpDown();
            this.TxtValorNovos = new System.Windows.Forms.TextBox();
            this.TxtValorDevolvidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.LVPesquisa = new System.Windows.Forms.ListView();
            this.CID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdDevolvido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAdicionarNovo = new System.Windows.Forms.Button();
            this.TxtNumQuantNovo = new System.Windows.Forms.NumericUpDown();
            this.LBITEMNovo = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIdnovo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCredito = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Linha = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.ListItensAntigos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuantDevolvido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuantNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(762, 301);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(95, 33);
            this.BtnFinalizar.TabIndex = 112;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(511, 101);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(209, 31);
            this.BtnPesquisar.TabIndex = 111;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnLimpar.Location = new System.Drawing.Point(762, 347);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(95, 35);
            this.BtnLimpar.TabIndex = 110;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnAdicionarDevolvido
            // 
            this.BtnAdicionarDevolvido.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionarDevolvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarDevolvido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionarDevolvido.Location = new System.Drawing.Point(12, 101);
            this.BtnAdicionarDevolvido.Name = "BtnAdicionarDevolvido";
            this.BtnAdicionarDevolvido.Size = new System.Drawing.Size(230, 32);
            this.BtnAdicionarDevolvido.TabIndex = 108;
            this.BtnAdicionarDevolvido.Text = "Adicionar";
            this.BtnAdicionarDevolvido.UseVisualStyleBackColor = false;
            this.BtnAdicionarDevolvido.Click += new System.EventHandler(this.BtnAdicionarDevolvido_Click);
            // 
            // TxtNumQuantDevolvido
            // 
            this.TxtNumQuantDevolvido.Location = new System.Drawing.Point(186, 67);
            this.TxtNumQuantDevolvido.Name = "TxtNumQuantDevolvido";
            this.TxtNumQuantDevolvido.Size = new System.Drawing.Size(56, 20);
            this.TxtNumQuantDevolvido.TabIndex = 107;
            this.TxtNumQuantDevolvido.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtValorNovos
            // 
            this.TxtValorNovos.BackColor = System.Drawing.Color.White;
            this.TxtValorNovos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorNovos.Location = new System.Drawing.Point(756, 147);
            this.TxtValorNovos.Name = "TxtValorNovos";
            this.TxtValorNovos.ReadOnly = true;
            this.TxtValorNovos.Size = new System.Drawing.Size(100, 13);
            this.TxtValorNovos.TabIndex = 104;
            // 
            // TxtValorDevolvidos
            // 
            this.TxtValorDevolvidos.BackColor = System.Drawing.Color.White;
            this.TxtValorDevolvidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValorDevolvidos.Location = new System.Drawing.Point(756, 198);
            this.TxtValorDevolvidos.Name = "TxtValorDevolvidos";
            this.TxtValorDevolvidos.ReadOnly = true;
            this.TxtValorDevolvidos.Size = new System.Drawing.Size(100, 13);
            this.TxtValorDevolvidos.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(753, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Valor intens devolvidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(760, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Valor itens novos:";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(566, 75);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(154, 20);
            this.TxtPesquisa.TabIndex = 100;
            // 
            // LVPesquisa
            // 
            this.LVPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CID,
            this.CNOME});
            this.LVPesquisa.HideSelection = false;
            this.LVPesquisa.Location = new System.Drawing.Point(511, 150);
            this.LVPesquisa.Name = "LVPesquisa";
            this.LVPesquisa.Size = new System.Drawing.Size(209, 292);
            this.LVPesquisa.TabIndex = 98;
            this.LVPesquisa.UseCompatibleStateImageBehavior = false;
            this.LVPesquisa.View = System.Windows.Forms.View.Details;
            // 
            // CID
            // 
            this.CID.Text = "Código:";
            this.CID.Width = 55;
            // 
            // CNOME
            // 
            this.CNOME.Text = "Nome";
            this.CNOME.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Quantidade devolvida:";
            // 
            // TxtIdDevolvido
            // 
            this.TxtIdDevolvido.Location = new System.Drawing.Point(186, 42);
            this.TxtIdDevolvido.Name = "TxtIdDevolvido";
            this.TxtIdDevolvido.Size = new System.Drawing.Size(56, 20);
            this.TxtIdDevolvido.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Código do produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Produto devolvido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Produto novo:";
            // 
            // BtnAdicionarNovo
            // 
            this.BtnAdicionarNovo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionarNovo.Location = new System.Drawing.Point(274, 101);
            this.BtnAdicionarNovo.Name = "BtnAdicionarNovo";
            this.BtnAdicionarNovo.Size = new System.Drawing.Size(215, 32);
            this.BtnAdicionarNovo.TabIndex = 119;
            this.BtnAdicionarNovo.Text = "Adicionar";
            this.BtnAdicionarNovo.UseVisualStyleBackColor = false;
            this.BtnAdicionarNovo.Click += new System.EventHandler(this.BtnAdicionarNovo_Click);
            // 
            // TxtNumQuantNovo
            // 
            this.TxtNumQuantNovo.Location = new System.Drawing.Point(431, 69);
            this.TxtNumQuantNovo.Name = "TxtNumQuantNovo";
            this.TxtNumQuantNovo.Size = new System.Drawing.Size(46, 20);
            this.TxtNumQuantNovo.TabIndex = 118;
            this.TxtNumQuantNovo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBITEMNovo
            // 
            this.LBITEMNovo.FormattingEnabled = true;
            this.LBITEMNovo.Location = new System.Drawing.Point(276, 139);
            this.LBITEMNovo.Name = "LBITEMNovo";
            this.LBITEMNovo.Size = new System.Drawing.Size(213, 303);
            this.LBITEMNovo.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Quantidade levada:";
            // 
            // TxtIdnovo
            // 
            this.TxtIdnovo.Location = new System.Drawing.Point(431, 43);
            this.TxtIdnovo.Name = "TxtIdnovo";
            this.TxtIdnovo.Size = new System.Drawing.Size(46, 20);
            this.TxtIdnovo.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Código do produto:";
            // 
            // TxtCredito
            // 
            this.TxtCredito.BackColor = System.Drawing.Color.White;
            this.TxtCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCredito.Location = new System.Drawing.Point(762, 250);
            this.TxtCredito.Name = "TxtCredito";
            this.TxtCredito.ReadOnly = true;
            this.TxtCredito.Size = new System.Drawing.Size(100, 13);
            this.TxtCredito.TabIndex = 122;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(783, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 121;
            this.label10.Text = "Crédito:";
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(835, 10);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 123;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // Linha
            // 
            this.Linha.BackColor = System.Drawing.Color.Orange;
            this.Linha.Location = new System.Drawing.Point(257, 10);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(1, 447);
            this.Linha.TabIndex = 125;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(276, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(504, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 447);
            this.panel1.TabIndex = 126;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(511, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 128;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(563, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 16);
            this.label11.TabIndex = 127;
            this.label11.Text = "Pesquisar produto por nome";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(775, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 132;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(756, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(806, 76);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(56, 16);
            this.LblUsuario.TabIndex = 134;
            this.LblUsuario.Text = "Usuário";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblData.Location = new System.Drawing.Point(806, 96);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(33, 15);
            this.LblData.TabIndex = 133;
            this.LblData.Text = "Data";
            // 
            // ListItensAntigos
            // 
            this.ListItensAntigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListItensAntigos.HideSelection = false;
            this.ListItensAntigos.Location = new System.Drawing.Point(12, 139);
            this.ListItensAntigos.Name = "ListItensAntigos";
            this.ListItensAntigos.Size = new System.Drawing.Size(230, 303);
            this.ListItensAntigos.TabIndex = 136;
            this.ListItensAntigos.UseCompatibleStateImageBehavior = false;
            this.ListItensAntigos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.Width = 70;
            // 
            // Troca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 474);
            this.Controls.Add(this.ListItensAntigos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.TxtCredito);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAdicionarNovo);
            this.Controls.Add(this.TxtNumQuantNovo);
            this.Controls.Add(this.LBITEMNovo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtIdnovo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnAdicionarDevolvido);
            this.Controls.Add(this.TxtNumQuantDevolvido);
            this.Controls.Add(this.TxtValorNovos);
            this.Controls.Add(this.TxtValorDevolvidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.LVPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdDevolvido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Troca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca";
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuantDevolvido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuantNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnAdicionarDevolvido;
        private System.Windows.Forms.NumericUpDown TxtNumQuantDevolvido;
        private System.Windows.Forms.TextBox TxtValorNovos;
        private System.Windows.Forms.TextBox TxtValorDevolvidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.ListView LVPesquisa;
        private System.Windows.Forms.ColumnHeader CID;
        private System.Windows.Forms.ColumnHeader CNOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdDevolvido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAdicionarNovo;
        private System.Windows.Forms.NumericUpDown TxtNumQuantNovo;
        private System.Windows.Forms.ListBox LBITEMNovo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIdnovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCredito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDuvida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Linha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.ListView ListItensAntigos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}