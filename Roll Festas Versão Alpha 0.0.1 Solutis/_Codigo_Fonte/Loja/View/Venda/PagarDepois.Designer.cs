namespace Loja.View.Venda
{
    partial class PagarDepois
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
            this.LblData = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.LblValorPago = new System.Windows.Forms.Label();
            this.LblValorRestante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtValorRestante = new System.Windows.Forms.TextBox();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTipoDePagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(15, 62);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(36, 13);
            this.LblData.TabIndex = 0;
            this.LblData.Text = "Data: ";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(12, 44);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(49, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuário: ";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.Location = new System.Drawing.Point(69, 119);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(159, 13);
            this.LblValorTotal.TabIndex = 2;
            this.LblValorTotal.Text = "Aguardando informações...";
            this.LblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValorPago
            // 
            this.LblValorPago.AutoSize = true;
            this.LblValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorPago.Location = new System.Drawing.Point(75, 146);
            this.LblValorPago.Name = "LblValorPago";
            this.LblValorPago.Size = new System.Drawing.Size(159, 13);
            this.LblValorPago.TabIndex = 3;
            this.LblValorPago.Text = "Aguardando informações...";
            // 
            // LblValorRestante
            // 
            this.LblValorRestante.AutoSize = true;
            this.LblValorRestante.Location = new System.Drawing.Point(18, 232);
            this.LblValorRestante.Name = "LblValorRestante";
            this.LblValorRestante.Size = new System.Drawing.Size(75, 13);
            this.LblValorRestante.TabIndex = 4;
            this.LblValorRestante.Text = "Valor restante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Venda com pagamento adiado";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcular.Location = new System.Drawing.Point(72, 180);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(79, 33);
            this.BtnCalcular.TabIndex = 37;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtValorRestante
            // 
            this.TxtValorRestante.Location = new System.Drawing.Point(99, 229);
            this.TxtValorRestante.Name = "TxtValorRestante";
            this.TxtValorRestante.Size = new System.Drawing.Size(100, 20);
            this.TxtValorRestante.TabIndex = 38;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(72, 266);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(79, 29);
            this.BtnFinalizar.TabIndex = 44;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Valor total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Valor pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tipo de pagamento:";
            // 
            // LblTipoDePagamento
            // 
            this.LblTipoDePagamento.AutoSize = true;
            this.LblTipoDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoDePagamento.Location = new System.Drawing.Point(111, 96);
            this.LblTipoDePagamento.Name = "LblTipoDePagamento";
            this.LblTipoDePagamento.Size = new System.Drawing.Size(112, 13);
            this.LblTipoDePagamento.TabIndex = 48;
            this.LblTipoDePagamento.Text = "Aguardando info...";
            // 
            // PagarDepois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(248, 320);
            this.Controls.Add(this.LblTipoDePagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.TxtValorRestante);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblValorRestante);
            this.Controls.Add(this.LblValorPago);
            this.Controls.Add(this.LblValorTotal);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagarDepois";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagarDepois";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Label LblValorPago;
        private System.Windows.Forms.Label LblValorRestante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtValorRestante;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTipoDePagamento;
    }
}