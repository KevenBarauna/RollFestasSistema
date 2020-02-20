namespace Loja.View.Venda
{
    partial class NovaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LVPesquisa = new System.Windows.Forms.ListView();
            this.CID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPRECO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblTestedata = new System.Windows.Forms.Label();
            this.RBOutros = new System.Windows.Forms.RadioButton();
            this.RBCartao = new System.Windows.Forms.RadioButton();
            this.RBDinheiro = new System.Windows.Forms.RadioButton();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBITEM = new System.Windows.Forms.ListBox();
            this.TxtNumQuant = new System.Windows.Forms.NumericUpDown();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnPagarDepos = new System.Windows.Forms.Button();
            this.RbDinCart = new System.Windows.Forms.RadioButton();
            this.TxtDinCart = new System.Windows.Forms.TextBox();
            this.LblDinCart = new System.Windows.Forms.Label();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Linha = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ImgAtencao = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAtencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do produto:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(168, 25);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(62, 20);
            this.TxtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // LVPesquisa
            // 
            this.LVPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CID,
            this.CNOME,
            this.CPRECO});
            this.LVPesquisa.HideSelection = false;
            this.LVPesquisa.Location = new System.Drawing.Point(268, 111);
            this.LVPesquisa.Name = "LVPesquisa";
            this.LVPesquisa.Size = new System.Drawing.Size(251, 342);
            this.LVPesquisa.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(341, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquisar produto por nome";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(336, 51);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(183, 20);
            this.TxtPesquisa.TabIndex = 6;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Turquoise;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcular.Location = new System.Drawing.Point(669, 135);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(84, 33);
            this.BtnCalcular.TabIndex = 36;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblTestedata
            // 
            this.LblTestedata.AutoSize = true;
            this.LblTestedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestedata.Location = new System.Drawing.Point(558, 43);
            this.LblTestedata.Name = "LblTestedata";
            this.LblTestedata.Size = new System.Drawing.Size(33, 15);
            this.LblTestedata.TabIndex = 35;
            this.LblTestedata.Text = "Data";
            // 
            // RBOutros
            // 
            this.RBOutros.AutoSize = true;
            this.RBOutros.Location = new System.Drawing.Point(702, 259);
            this.RBOutros.Name = "RBOutros";
            this.RBOutros.Size = new System.Drawing.Size(56, 17);
            this.RBOutros.TabIndex = 34;
            this.RBOutros.Text = "Outros";
            this.RBOutros.UseVisualStyleBackColor = true;
            this.RBOutros.CheckedChanged += new System.EventHandler(this.RBOutros_CheckedChanged);
            // 
            // RBCartao
            // 
            this.RBCartao.AutoSize = true;
            this.RBCartao.Location = new System.Drawing.Point(640, 259);
            this.RBCartao.Name = "RBCartao";
            this.RBCartao.Size = new System.Drawing.Size(56, 17);
            this.RBCartao.TabIndex = 33;
            this.RBCartao.Text = "Cartão";
            this.RBCartao.UseVisualStyleBackColor = true;
            this.RBCartao.CheckedChanged += new System.EventHandler(this.RBCartao_CheckedChanged);
            // 
            // RBDinheiro
            // 
            this.RBDinheiro.AutoSize = true;
            this.RBDinheiro.Checked = true;
            this.RBDinheiro.Location = new System.Drawing.Point(570, 259);
            this.RBDinheiro.Name = "RBDinheiro";
            this.RBDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RBDinheiro.TabIndex = 31;
            this.RBDinheiro.TabStop = true;
            this.RBDinheiro.Text = "Dinheiro";
            this.RBDinheiro.UseVisualStyleBackColor = true;
            this.RBDinheiro.CheckedChanged += new System.EventHandler(this.RBDinheiro_CheckedChanged);
            // 
            // TxtTroco
            // 
            this.TxtTroco.BackColor = System.Drawing.Color.White;
            this.TxtTroco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTroco.Location = new System.Drawing.Point(562, 155);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(84, 13);
            this.TxtTroco.TabIndex = 30;
            // 
            // TxtValor
            // 
            this.TxtValor.BackColor = System.Drawing.Color.White;
            this.TxtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtValor.Location = new System.Drawing.Point(668, 98);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(83, 13);
            this.TxtValor.TabIndex = 29;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.White;
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotal.Location = new System.Drawing.Point(560, 99);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(84, 13);
            this.TxtTotal.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Troco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tipo de pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Valor recebido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total";
            // 
            // LBITEM
            // 
            this.LBITEM.FormattingEnabled = true;
            this.LBITEM.Location = new System.Drawing.Point(16, 111);
            this.LBITEM.Name = "LBITEM";
            this.LBITEM.Size = new System.Drawing.Size(214, 342);
            this.LBITEM.TabIndex = 37;
            // 
            // TxtNumQuant
            // 
            this.TxtNumQuant.Location = new System.Drawing.Point(168, 51);
            this.TxtNumQuant.Name = "TxtNumQuant";
            this.TxtNumQuant.Size = new System.Drawing.Size(62, 20);
            this.TxtNumQuant.TabIndex = 38;
            this.TxtNumQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionar.Location = new System.Drawing.Point(16, 75);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(214, 32);
            this.BtnAdicionar.TabIndex = 39;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(556, 18);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(56, 16);
            this.LblUsuario.TabIndex = 40;
            this.LblUsuario.Text = "Usuário";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnLimpar.Location = new System.Drawing.Point(880, 124);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(92, 35);
            this.BtnLimpar.TabIndex = 41;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnCalcularValorItem_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(268, 75);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(251, 32);
            this.BtnPesquisar.TabIndex = 42;
            this.BtnPesquisar.Text = "Buscar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(880, 282);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(92, 35);
            this.BtnFinalizar.TabIndex = 43;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnPagarDepos
            // 
            this.BtnPagarDepos.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnPagarDepos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagarDepos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPagarDepos.Location = new System.Drawing.Point(880, 177);
            this.BtnPagarDepos.Name = "BtnPagarDepos";
            this.BtnPagarDepos.Size = new System.Drawing.Size(92, 35);
            this.BtnPagarDepos.TabIndex = 44;
            this.BtnPagarDepos.Text = "Pagar depois";
            this.BtnPagarDepos.UseVisualStyleBackColor = false;
            this.BtnPagarDepos.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbDinCart
            // 
            this.RbDinCart.AutoSize = true;
            this.RbDinCart.Location = new System.Drawing.Point(570, 282);
            this.RbDinCart.Name = "RbDinCart";
            this.RbDinCart.Size = new System.Drawing.Size(107, 17);
            this.RbDinCart.TabIndex = 45;
            this.RbDinCart.Text = "Dinheiro e Cartão";
            this.RbDinCart.UseVisualStyleBackColor = true;
            this.RbDinCart.CheckedChanged += new System.EventHandler(this.RbDinCart_CheckedChanged);
            // 
            // TxtDinCart
            // 
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtDinCart.Location = new System.Drawing.Point(680, 281);
            this.TxtDinCart.Name = "TxtDinCart";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Size = new System.Drawing.Size(78, 20);
            this.TxtDinCart.TabIndex = 46;
            // 
            // LblDinCart
            // 
            this.LblDinCart.BackColor = System.Drawing.Color.White;
            this.LblDinCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDinCart.ForeColor = System.Drawing.Color.Red;
            this.LblDinCart.Location = new System.Drawing.Point(640, 323);
            this.LblDinCart.Name = "LblDinCart";
            this.LblDinCart.Size = new System.Drawing.Size(142, 50);
            this.LblDinCart.TabIndex = 47;
            this.LblDinCart.Text = "Informe o valor pago em cartão no campo acima!";
            this.LblDinCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDinCart.Visible = false;
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(937, 10);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 48;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(880, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 49;
            this.button1.Text = "Descontos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(263, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Linha
            // 
            this.Linha.BackColor = System.Drawing.Color.Orange;
            this.Linha.Location = new System.Drawing.Point(247, 10);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(1, 447);
            this.Linha.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(537, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 447);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(560, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 1);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(667, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 1);
            this.panel3.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(562, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 1);
            this.panel4.TabIndex = 55;
            // 
            // ImgAtencao
            // 
            this.ImgAtencao.Image = ((System.Drawing.Image)(resources.GetObject("ImgAtencao.Image")));
            this.ImgAtencao.Location = new System.Drawing.Point(573, 318);
            this.ImgAtencao.Name = "ImgAtencao";
            this.ImgAtencao.Size = new System.Drawing.Size(61, 61);
            this.ImgAtencao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgAtencao.TabIndex = 63;
            this.ImgAtencao.TabStop = false;
            this.ImgAtencao.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(842, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 66;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(842, 176);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 65;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(842, 125);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 34);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 64;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(842, 282);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 67;
            this.pictureBox10.TabStop = false;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Red;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.ForeColor = System.Drawing.SystemColors.Info;
            this.Cancelar.Location = new System.Drawing.Point(880, 414);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(92, 35);
            this.Cancelar.TabIndex = 68;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.ImgAtencao);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtNumQuant);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnPagarDepos);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.LblDinCart);
            this.Controls.Add(this.TxtDinCart);
            this.Controls.Add(this.RbDinCart);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LBITEM);
            this.Controls.Add(this.LblTestedata);
            this.Controls.Add(this.RBOutros);
            this.Controls.Add(this.RBCartao);
            this.Controls.Add(this.RBDinheiro);
            this.Controls.Add(this.TxtTroco);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LVPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Venda";
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAtencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LVPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblTestedata;
        private System.Windows.Forms.RadioButton RBOutros;
        private System.Windows.Forms.RadioButton RBCartao;
        private System.Windows.Forms.RadioButton RBDinheiro;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LBITEM;
        private System.Windows.Forms.NumericUpDown TxtNumQuant;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.ColumnHeader CID;
        private System.Windows.Forms.ColumnHeader CNOME;
        private System.Windows.Forms.ColumnHeader CPRECO;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnPagarDepos;
        private System.Windows.Forms.RadioButton RbDinCart;
        private System.Windows.Forms.TextBox TxtDinCart;
        private System.Windows.Forms.Label LblDinCart;
        private System.Windows.Forms.Button BtnDuvida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Linha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ImgAtencao;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button Cancelar;
    }
}