﻿namespace M11_TbF
{
    partial class Form_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_criar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_layout = new System.Windows.Forms.Panel();
            this.label_SIGN_UP = new System.Windows.Forms.Label();
            this.label_entrar_login = new System.Windows.Forms.Label();
            this.textBox_ConfPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_JTemCnt = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.panel_layout2 = new System.Windows.Forms.Panel();
            this.label_UserPass = new System.Windows.Forms.Label();
            this.label_passcoincide = new System.Windows.Forms.Label();
            this.label_sign = new System.Windows.Forms.Label();
            this.label_sign2 = new System.Windows.Forms.Label();
            this.panel_layout.SuspendLayout();
            this.panel_layout2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // button_criar
            // 
            this.button_criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_criar.FlatAppearance.BorderSize = 3;
            this.button_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_criar.ForeColor = System.Drawing.Color.White;
            this.button_criar.Location = new System.Drawing.Point(15, 314);
            this.button_criar.Name = "button_criar";
            this.button_criar.Size = new System.Drawing.Size(153, 40);
            this.button_criar.TabIndex = 4;
            this.button_criar.Text = "Criar";
            this.button_criar.UseVisualStyleBackColor = false;
            this.button_criar.Click += new System.EventHandler(this.button_criar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 27);
            this.panel2.TabIndex = 20;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel_layout
            // 
            this.panel_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_layout.Controls.Add(this.label_sign2);
            this.panel_layout.Controls.Add(this.label_passcoincide);
            this.panel_layout.Controls.Add(this.label_sign);
            this.panel_layout.Controls.Add(this.label_UserPass);
            this.panel_layout.Controls.Add(this.panel_layout2);
            this.panel_layout.Controls.Add(this.label_SIGN_UP);
            this.panel_layout.Controls.Add(this.textBox_ConfPassword);
            this.panel_layout.Controls.Add(this.label3);
            this.panel_layout.Controls.Add(this.button_minimizar);
            this.panel_layout.Controls.Add(this.button_sair);
            this.panel_layout.Controls.Add(this.textBox_Password);
            this.panel_layout.Controls.Add(this.textBox_Username);
            this.panel_layout.Controls.Add(this.button_criar);
            this.panel_layout.Controls.Add(this.label1);
            this.panel_layout.Controls.Add(this.label2);
            this.panel_layout.Location = new System.Drawing.Point(720, 0);
            this.panel_layout.Name = "panel_layout";
            this.panel_layout.Size = new System.Drawing.Size(182, 403);
            this.panel_layout.TabIndex = 21;
            // 
            // label_SIGN_UP
            // 
            this.label_SIGN_UP.AutoSize = true;
            this.label_SIGN_UP.BackColor = System.Drawing.Color.Transparent;
            this.label_SIGN_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_SIGN_UP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_SIGN_UP.Location = new System.Drawing.Point(12, 46);
            this.label_SIGN_UP.Name = "label_SIGN_UP";
            this.label_SIGN_UP.Size = new System.Drawing.Size(77, 20);
            this.label_SIGN_UP.TabIndex = 28;
            this.label_SIGN_UP.Text = "SIGN UP";
            // 
            // label_entrar_login
            // 
            this.label_entrar_login.AutoSize = true;
            this.label_entrar_login.BackColor = System.Drawing.Color.Transparent;
            this.label_entrar_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_entrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_entrar_login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_entrar_login.Location = new System.Drawing.Point(12, 18);
            this.label_entrar_login.Name = "label_entrar_login";
            this.label_entrar_login.Size = new System.Drawing.Size(73, 17);
            this.label_entrar_login.TabIndex = 24;
            this.label_entrar_login.Text = "Entre aqui";
            this.label_entrar_login.Click += new System.EventHandler(this.label_entrar_login_Click);
            // 
            // textBox_ConfPassword
            // 
            this.textBox_ConfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_ConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_ConfPassword.ForeColor = System.Drawing.Color.White;
            this.textBox_ConfPassword.Location = new System.Drawing.Point(15, 273);
            this.textBox_ConfPassword.Name = "textBox_ConfPassword";
            this.textBox_ConfPassword.PasswordChar = '*';
            this.textBox_ConfPassword.Size = new System.Drawing.Size(153, 23);
            this.textBox_ConfPassword.TabIndex = 27;
            this.textBox_ConfPassword.TextChanged += new System.EventHandler(this.textBox_ConfPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Confirmar Password:";
            // 
            // button_minimizar
            // 
            this.button_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.ForeColor = System.Drawing.Color.White;
            this.button_minimizar.Location = new System.Drawing.Point(133, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(24, 24);
            this.button_minimizar.TabIndex = 17;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = false;
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
            // label_JTemCnt
            // 
            this.label_JTemCnt.AutoSize = true;
            this.label_JTemCnt.BackColor = System.Drawing.Color.Transparent;
            this.label_JTemCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_JTemCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_JTemCnt.Location = new System.Drawing.Point(12, 2);
            this.label_JTemCnt.Name = "label_JTemCnt";
            this.label_JTemCnt.Size = new System.Drawing.Size(128, 17);
            this.label_JTemCnt.TabIndex = 25;
            this.label_JTemCnt.Text = "Já tem uma conta?";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(15, 219);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(153, 23);
            this.textBox_Password.TabIndex = 22;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_Username.ForeColor = System.Drawing.Color.White;
            this.textBox_Username.Location = new System.Drawing.Point(15, 152);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(153, 23);
            this.textBox_Username.TabIndex = 23;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // panel_layout2
            // 
            this.panel_layout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_layout2.Controls.Add(this.label_JTemCnt);
            this.panel_layout2.Controls.Add(this.label_entrar_login);
            this.panel_layout2.Location = new System.Drawing.Point(0, 358);
            this.panel_layout2.Name = "panel_layout2";
            this.panel_layout2.Size = new System.Drawing.Size(182, 45);
            this.panel_layout2.TabIndex = 26;
            // 
            // label_UserPass
            // 
            this.label_UserPass.AutoSize = true;
            this.label_UserPass.BackColor = System.Drawing.Color.Transparent;
            this.label_UserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label_UserPass.ForeColor = System.Drawing.Color.Red;
            this.label_UserPass.Location = new System.Drawing.Point(31, 73);
            this.label_UserPass.Name = "label_UserPass";
            this.label_UserPass.Size = new System.Drawing.Size(147, 32);
            this.label_UserPass.TabIndex = 31;
            this.label_UserPass.Text = "User e Pass têm de ter \r\nentre 3-10 caracteres";
            // 
            // label_passcoincide
            // 
            this.label_passcoincide.AutoSize = true;
            this.label_passcoincide.BackColor = System.Drawing.Color.Transparent;
            this.label_passcoincide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label_passcoincide.ForeColor = System.Drawing.Color.Red;
            this.label_passcoincide.Location = new System.Drawing.Point(31, 108);
            this.label_passcoincide.Name = "label_passcoincide";
            this.label_passcoincide.Size = new System.Drawing.Size(140, 16);
            this.label_passcoincide.TabIndex = 32;
            this.label_passcoincide.Text = "Passwords coincidem";
            // 
            // label_sign
            // 
            this.label_sign.AutoSize = true;
            this.label_sign.BackColor = System.Drawing.Color.Transparent;
            this.label_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label_sign.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_sign.Location = new System.Drawing.Point(13, 79);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(18, 17);
            this.label_sign.TabIndex = 32;
            this.label_sign.Text = "☉";
            // 
            // label_sign2
            // 
            this.label_sign2.AutoSize = true;
            this.label_sign2.BackColor = System.Drawing.Color.Transparent;
            this.label_sign2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label_sign2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_sign2.Location = new System.Drawing.Point(13, 107);
            this.label_sign2.Name = "label_sign2";
            this.label_sign2.Size = new System.Drawing.Size(18, 17);
            this.label_sign2.TabIndex = 33;
            this.label_sign2.Text = "☉";
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.Controls.Add(this.panel_layout);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SignUp";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            this.panel_layout.ResumeLayout(false);
            this.panel_layout.PerformLayout();
            this.panel_layout2.ResumeLayout(false);
            this.panel_layout2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_criar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_layout;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_entrar_login;
        private System.Windows.Forms.Label label_JTemCnt;
        private System.Windows.Forms.TextBox textBox_ConfPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_SIGN_UP;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Panel panel_layout2;
        private System.Windows.Forms.Label label_sign2;
        private System.Windows.Forms.Label label_passcoincide;
        private System.Windows.Forms.Label label_sign;
        private System.Windows.Forms.Label label_UserPass;
    }
}