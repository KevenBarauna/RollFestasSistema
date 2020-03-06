namespace RollFestas.View.Avisos
{
    partial class MensagemAlerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemAlerta));
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblAlerta = new System.Windows.Forms.Label();
            this.ImgErro = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImgErro)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnOk.Location = new System.Drawing.Point(179, 126);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(82, 31);
            this.BtnOk.TabIndex = 49;
            this.BtnOk.Text = "Ok!";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblAlerta
            // 
            this.LblAlerta.BackColor = System.Drawing.Color.White;
            this.LblAlerta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblAlerta.Location = new System.Drawing.Point(126, 12);
            this.LblAlerta.Name = "LblAlerta";
            this.LblAlerta.Size = new System.Drawing.Size(292, 109);
            this.LblAlerta.TabIndex = 48;
            this.LblAlerta.Text = "Alerta!";
            this.LblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgErro
            // 
            this.ImgErro.Image = ((System.Drawing.Image)(resources.GetObject("ImgErro.Image")));
            this.ImgErro.Location = new System.Drawing.Point(12, 12);
            this.ImgErro.Name = "ImgErro";
            this.ImgErro.Size = new System.Drawing.Size(108, 109);
            this.ImgErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgErro.TabIndex = 47;
            this.ImgErro.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(0, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 7);
            this.panel3.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 7);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(425, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 183);
            this.panel2.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(0, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 183);
            this.panel4.TabIndex = 55;
            // 
            // MensagemAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 171);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblAlerta);
            this.Controls.Add(this.ImgErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MensagemAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensagemAlerta";
            ((System.ComponentModel.ISupportInitialize)(this.ImgErro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblAlerta;
        private System.Windows.Forms.PictureBox ImgErro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}