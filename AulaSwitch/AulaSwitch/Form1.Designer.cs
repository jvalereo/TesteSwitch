namespace AulaSwitch
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.cobSemana = new System.Windows.Forms.ComboBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(81, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Aula Switch";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(52, 99);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(174, 20);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Escolha um Dia da Semana";
            // 
            // cobSemana
            // 
            this.cobSemana.FormattingEnabled = true;
            this.cobSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda - feira",
            "Terça - feira",
            "Quarta - feira",
            "Quinta - feira",
            "Sexta - feira",
            "Sábado"});
            this.cobSemana.Location = new System.Drawing.Point(78, 139);
            this.cobSemana.Name = "cobSemana";
            this.cobSemana.Size = new System.Drawing.Size(121, 21);
            this.cobSemana.TabIndex = 2;
            this.cobSemana.SelectedIndexChanged += new System.EventHandler(this.cobSemana_SelectedIndexChanged);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(99, 200);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(83, 32);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.cobSemana);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.ComboBox cobSemana;
        private System.Windows.Forms.Button BtnFechar;
    }
}

