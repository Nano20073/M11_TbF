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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_MudarUsername = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_MudarPassword = new System.Windows.Forms.Button();
            this.label_OPCOES = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NovoUsername
            // 
            this.label_NovoUsername.AutoSize = true;
            this.label_NovoUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_NovoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NovoUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NovoUsername.Location = new System.Drawing.Point(13, 229);
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
            this.label_ConfirmarNovoUsername.Location = new System.Drawing.Point(13, 283);
            this.label_ConfirmarNovoUsername.Name = "label_ConfirmarNovoUsername";
            this.label_ConfirmarNovoUsername.Size = new System.Drawing.Size(142, 17);
            this.label_ConfirmarNovoUsername.TabIndex = 1;
            this.label_ConfirmarNovoUsername.Text = "Confirmar Username:";
            // 
            // textBox_NovoUtilizador
            // 
            this.textBox_NovoUtilizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_NovoUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NovoUtilizador.ForeColor = System.Drawing.Color.White;
            this.textBox_NovoUtilizador.Location = new System.Drawing.Point(16, 249);
            this.textBox_NovoUtilizador.Name = "textBox_NovoUtilizador";
            this.textBox_NovoUtilizador.Size = new System.Drawing.Size(152, 20);
            this.textBox_NovoUtilizador.TabIndex = 2;
            // 
            // textBox_ConfirmarNovoUsername
            // 
            this.textBox_ConfirmarNovoUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_ConfirmarNovoUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConfirmarNovoUsername.ForeColor = System.Drawing.Color.White;
            this.textBox_ConfirmarNovoUsername.Location = new System.Drawing.Point(16, 303);
            this.textBox_ConfirmarNovoUsername.Name = "textBox_ConfirmarNovoUsername";
            this.textBox_ConfirmarNovoUsername.Size = new System.Drawing.Size(152, 20);
            this.textBox_ConfirmarNovoUsername.TabIndex = 3;
            // 
            // button_Alterar
            // 
            this.button_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Alterar.ForeColor = System.Drawing.Color.White;
            this.button_Alterar.Location = new System.Drawing.Point(14, 343);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(154, 49);
            this.button_Alterar.TabIndex = 4;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = false;
            this.button_Alterar.Click += new System.EventHandler(this.button_Alterar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_Alterar);
            this.panel3.Controls.Add(this.button_MudarUsername);
            this.panel3.Controls.Add(this.textBox_ConfirmarNovoUsername);
            this.panel3.Controls.Add(this.button_Reset);
            this.panel3.Controls.Add(this.label_ConfirmarNovoUsername);
            this.panel3.Controls.Add(this.textBox_NovoUtilizador);
            this.panel3.Controls.Add(this.button_MudarPassword);
            this.panel3.Controls.Add(this.label_OPCOES);
            this.panel3.Controls.Add(this.label_NovoUsername);
            this.panel3.Controls.Add(this.button_minimizar);
            this.panel3.Controls.Add(this.button_sair);
            this.panel3.Location = new System.Drawing.Point(720, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 403);
            this.panel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 1);
            this.label1.TabIndex = 26;
            // 
            // button_MudarUsername
            // 
            this.button_MudarUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_MudarUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MudarUsername.FlatAppearance.BorderSize = 2;
            this.button_MudarUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MudarUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_MudarUsername.ForeColor = System.Drawing.Color.Aqua;
            this.button_MudarUsername.Location = new System.Drawing.Point(15, 116);
            this.button_MudarUsername.Name = "button_MudarUsername";
            this.button_MudarUsername.Size = new System.Drawing.Size(153, 40);
            this.button_MudarUsername.TabIndex = 21;
            this.button_MudarUsername.Text = "Mudar Username";
            this.button_MudarUsername.UseVisualStyleBackColor = false;
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Reset.ForeColor = System.Drawing.Color.White;
            this.button_Reset.Location = new System.Drawing.Point(15, 70);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(153, 40);
            this.button_Reset.TabIndex = 20;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_MudarPassword
            // 
            this.button_MudarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_MudarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MudarPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MudarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MudarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_MudarPassword.ForeColor = System.Drawing.Color.White;
            this.button_MudarPassword.Location = new System.Drawing.Point(15, 162);
            this.button_MudarPassword.Name = "button_MudarPassword";
            this.button_MudarPassword.Size = new System.Drawing.Size(153, 40);
            this.button_MudarPassword.TabIndex = 22;
            this.button_MudarPassword.Text = "Mudar a Password";
            this.button_MudarPassword.UseVisualStyleBackColor = false;
            this.button_MudarPassword.Click += new System.EventHandler(this.button_MudarPassword_Click);
            // 
            // label_OPCOES
            // 
            this.label_OPCOES.AutoSize = true;
            this.label_OPCOES.BackColor = System.Drawing.Color.Transparent;
            this.label_OPCOES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_OPCOES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_OPCOES.ForeColor = System.Drawing.Color.White;
            this.label_OPCOES.Location = new System.Drawing.Point(12, 46);
            this.label_OPCOES.Name = "label_OPCOES";
            this.label_OPCOES.Size = new System.Drawing.Size(80, 20);
            this.label_OPCOES.TabIndex = 25;
            this.label_OPCOES.Text = "OPÇÕES";
            this.label_OPCOES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_OPCOES.Click += new System.EventHandler(this.label_OPCOES_Click);
            // 
            // button_minimizar
            // 
            this.button_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.ForeColor = System.Drawing.Color.White;
            this.button_minimizar.Location = new System.Drawing.Point(133, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(24, 24);
            this.button_minimizar.TabIndex = 17;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_sair.ForeColor = System.Drawing.Color.White;
            this.button_sair.Location = new System.Drawing.Point(156, 0);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(24, 24);
            this.button_sair.TabIndex = 3;
            this.button_sair.Text = "x";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // Form_MudarNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.FormBG;
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_MudarNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MudarNome";
            this.Load += new System.EventHandler(this.Form_MudarNome_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_NovoUsername;
        private System.Windows.Forms.Label label_ConfirmarNovoUsername;
        private System.Windows.Forms.TextBox textBox_NovoUtilizador;
        private System.Windows.Forms.TextBox textBox_ConfirmarNovoUsername;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_MudarUsername;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_MudarPassword;
        private System.Windows.Forms.Label label_OPCOES;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Button button_sair;
    }
}