namespace RollFestas.View.Evento
{
    partial class TodosOsEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosOsEventos));
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImgProximasEncomendas = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListEntregas = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Entrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Entregue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.button1.Location = new System.Drawing.Point(1151, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 37;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.ImgProximasEncomendas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 52);
            this.panel3.TabIndex = 36;
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
            this.label3.Font = new System.Drawing.Font("Amiri Quran", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(476, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 54);
            this.label3.TabIndex = 27;
            this.label3.Text = "Eventos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListEntregas
            // 
            this.ListEntregas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Cep,
            this.Local,
            this.Desc,
            this.Cliente,
            this.Tel1,
            this.Tel2,
            this.Email,
            this.Tipo,
            this.Data,
            this.Hora,
            this.ValorTotal,
            this.Entrada,
            this.Entregue});
            this.ListEntregas.HideSelection = false;
            this.ListEntregas.Location = new System.Drawing.Point(12, 62);
            this.ListEntregas.Name = "ListEntregas";
            this.ListEntregas.Size = new System.Drawing.Size(1209, 358);
            this.ListEntregas.TabIndex = 35;
            this.ListEntregas.UseCompatibleStateImageBehavior = false;
            this.ListEntregas.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Código:";
            // 
            // Cep
            // 
            this.Cep.Text = "CEP:";
            this.Cep.Width = 90;
            // 
            // Local
            // 
            this.Local.Text = "Local:";
            this.Local.Width = 100;
            // 
            // Desc
            // 
            this.Desc.Text = "Descrição:";
            this.Desc.Width = 100;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente:";
            this.Cliente.Width = 80;
            // 
            // Tel1
            // 
            this.Tel1.Text = "Telefone(1)";
            this.Tel1.Width = 80;
            // 
            // Tel2
            // 
            this.Tel2.Text = "Telefone(2)";
            this.Tel2.Width = 80;
            // 
            // Email
            // 
            this.Email.Text = "E-mail:";
            this.Email.Width = 100;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo:";
            this.Tipo.Width = 100;
            // 
            // Data
            // 
            this.Data.Text = "Data:";
            this.Data.Width = 100;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora:";
            this.Hora.Width = 70;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor total:";
            this.ValorTotal.Width = 90;
            // 
            // Entrada
            // 
            this.Entrada.Text = "Valor entrada:";
            this.Entrada.Width = 90;
            // 
            // Entregue
            // 
            this.Entregue.Text = "Entregue:";
            this.Entregue.Width = 80;
            // 
            // TodosOsEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ListEntregas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TodosOsEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosOsEventos";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProximasEncomendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ImgProximasEncomendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListEntregas;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Cep;
        private System.Windows.Forms.ColumnHeader Local;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Tel1;
        private System.Windows.Forms.ColumnHeader Tel2;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.ColumnHeader Entrada;
        private System.Windows.Forms.ColumnHeader Entregue;
    }
}