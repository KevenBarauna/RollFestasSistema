namespace Loja.View
{
    partial class Erro
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
            this.LblNumeroErro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSolucao01 = new System.Windows.Forms.Label();
            this.LblSolucao02 = new System.Windows.Forms.Label();
            this.LblSolucao03 = new System.Windows.Forms.Label();
            this.LblSolucao04 = new System.Windows.Forms.Label();
            this.LblSolucao05 = new System.Windows.Forms.Label();
            this.TxtErro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNumeroErro
            // 
            this.LblNumeroErro.AutoSize = true;
            this.LblNumeroErro.Location = new System.Drawing.Point(26, 14);
            this.LblNumeroErro.Name = "LblNumeroErro";
            this.LblNumeroErro.Size = new System.Drawing.Size(43, 14);
            this.LblNumeroErro.TabIndex = 0;
            this.LblNumeroErro.Text = "Erro n° ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "= (";
            // 
            // LblSolucao01
            // 
            this.LblSolucao01.AutoSize = true;
            this.LblSolucao01.Location = new System.Drawing.Point(26, 44);
            this.LblSolucao01.Name = "LblSolucao01";
            this.LblSolucao01.Size = new System.Drawing.Size(52, 14);
            this.LblSolucao01.TabIndex = 3;
            this.LblSolucao01.Text = "Solução: ";
            // 
            // LblSolucao02
            // 
            this.LblSolucao02.AutoSize = true;
            this.LblSolucao02.Location = new System.Drawing.Point(26, 68);
            this.LblSolucao02.Name = "LblSolucao02";
            this.LblSolucao02.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao02.TabIndex = 4;
            // 
            // LblSolucao03
            // 
            this.LblSolucao03.AutoSize = true;
            this.LblSolucao03.Location = new System.Drawing.Point(26, 96);
            this.LblSolucao03.Name = "LblSolucao03";
            this.LblSolucao03.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao03.TabIndex = 5;
            // 
            // LblSolucao04
            // 
            this.LblSolucao04.AutoSize = true;
            this.LblSolucao04.Location = new System.Drawing.Point(26, 121);
            this.LblSolucao04.Name = "LblSolucao04";
            this.LblSolucao04.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao04.TabIndex = 6;
            // 
            // LblSolucao05
            // 
            this.LblSolucao05.AutoSize = true;
            this.LblSolucao05.Location = new System.Drawing.Point(26, 146);
            this.LblSolucao05.Name = "LblSolucao05";
            this.LblSolucao05.Size = new System.Drawing.Size(0, 14);
            this.LblSolucao05.TabIndex = 7;
            // 
            // TxtErro
            // 
            this.TxtErro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtErro.Location = new System.Drawing.Point(29, 182);
            this.TxtErro.Multiline = true;
            this.TxtErro.Name = "TxtErro";
            this.TxtErro.ReadOnly = true;
            this.TxtErro.Size = new System.Drawing.Size(519, 82);
            this.TxtErro.TabIndex = 8;
            // 
            // Erro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 277);
            this.Controls.Add(this.TxtErro);
            this.Controls.Add(this.LblSolucao05);
            this.Controls.Add(this.LblSolucao04);
            this.Controls.Add(this.LblSolucao03);
            this.Controls.Add(this.LblSolucao02);
            this.Controls.Add(this.LblSolucao01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNumeroErro);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Erro";
            this.Text = "Erro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeroErro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSolucao01;
        private System.Windows.Forms.Label LblSolucao02;
        private System.Windows.Forms.Label LblSolucao03;
        private System.Windows.Forms.Label LblSolucao04;
        private System.Windows.Forms.Label LblSolucao05;
        private System.Windows.Forms.TextBox TxtErro;
    }
}