namespace M11_TbF
{
    partial class Form_MudarNome
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
            this.label_NovoUsername = new System.Windows.Forms.Label();
            this.label_ConfirmarNovoUsername = new System.Windows.Forms.Label();
            this.textBox_NovoUtilizador = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmarNovoUsername = new System.Windows.Forms.TextBox();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NovoUsername
            // 
            this.label_NovoUsername.AutoSize = true;
            this.label_NovoUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_NovoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NovoUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NovoUsername.Location = new System.Drawing.Point(12, 9);
            this.label_NovoUsername.Name = "label_NovoUsername";
            this.label_NovoUsername.Size = new System.Drawing.Size(114, 17);
            this.label_NovoUsername.TabIndex = 0;
            this.label_NovoUsername.Text = "Novo Username:";
            // 
            // label_ConfirmarNovoUsername
            // 
            this.label_ConfirmarNovoUsername.AutoSize = true;
            this.label_ConfirmarNovoUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_ConfirmarNovoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_ConfirmarNovoUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_ConfirmarNovoUsername.Location = new System.Drawing.Point(12, 35);
            this.label_ConfirmarNovoUsername.Name = "label_ConfirmarNovoUsername";
            this.label_ConfirmarNovoUsername.Size = new System.Drawing.Size(177, 17);
            this.label_ConfirmarNovoUsername.TabIndex = 1;
            this.label_ConfirmarNovoUsername.Text = "Confirmar novo Username:";
            // 
            // textBox_NovoUtilizador
            // 
            this.textBox_NovoUtilizador.Location = new System.Drawing.Point(192, 9);
            this.textBox_NovoUtilizador.Name = "textBox_NovoUtilizador";
            this.textBox_NovoUtilizador.Size = new System.Drawing.Size(100, 20);
            this.textBox_NovoUtilizador.TabIndex = 2;
            // 
            // textBox_ConfirmarNovoUsername
            // 
            this.textBox_ConfirmarNovoUsername.Location = new System.Drawing.Point(192, 36);
            this.textBox_ConfirmarNovoUsername.Name = "textBox_ConfirmarNovoUsername";
            this.textBox_ConfirmarNovoUsername.Size = new System.Drawing.Size(100, 20);
            this.textBox_ConfirmarNovoUsername.TabIndex = 3;
            // 
            // button_Alterar
            // 
            this.button_Alterar.Location = new System.Drawing.Point(318, 7);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(75, 49);
            this.button_Alterar.TabIndex = 4;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = true;
            this.button_Alterar.Click += new System.EventHandler(this.button_Alterar_Click);
            // 
            // Form_MudarNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.backgroundDefault;
            this.ClientSize = new System.Drawing.Size(405, 68);
            this.Controls.Add(this.button_Alterar);
            this.Controls.Add(this.textBox_ConfirmarNovoUsername);
            this.Controls.Add(this.textBox_NovoUtilizador);
            this.Controls.Add(this.label_ConfirmarNovoUsername);
            this.Controls.Add(this.label_NovoUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_MudarNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MudarNome";
            this.Load += new System.EventHandler(this.Form_MudarNome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NovoUsername;
        private System.Windows.Forms.Label label_ConfirmarNovoUsername;
        private System.Windows.Forms.TextBox textBox_NovoUtilizador;
        private System.Windows.Forms.TextBox textBox_ConfirmarNovoUsername;
        private System.Windows.Forms.Button button_Alterar;
    }
}