namespace M11_TbF
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.button_Logar = new System.Windows.Forms.Button();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_NTemCnt = new System.Windows.Forms.Label();
            this.label_SignUP = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.panel_Drag = new System.Windows.Forms.Panel();
            this.panel_layout = new System.Windows.Forms.Panel();
            this.label_LOGIN = new System.Windows.Forms.Label();
            this.panel_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_UserName.Location = new System.Drawing.Point(12, 78);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(77, 17);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "Username:";
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.label_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_PassWord.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_PassWord.Location = new System.Drawing.Point(12, 145);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(73, 17);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "Password:";
            // 
            // button_Logar
            // 
            this.button_Logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Logar.ForeColor = System.Drawing.Color.White;
            this.button_Logar.Location = new System.Drawing.Point(15, 205);
            this.button_Logar.Name = "button_Logar";
            this.button_Logar.Size = new System.Drawing.Size(153, 40);
            this.button_Logar.TabIndex = 3;
            this.button_Logar.Text = "Login";
            this.button_Logar.UseVisualStyleBackColor = false;
            this.button_Logar.Click += new System.EventHandler(this.button_Logar_Click);
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_PassWord.ForeColor = System.Drawing.Color.White;
            this.textBox_PassWord.Location = new System.Drawing.Point(15, 165);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.Size = new System.Drawing.Size(153, 23);
            this.textBox_PassWord.TabIndex = 4;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_UserName.ForeColor = System.Drawing.Color.White;
            this.textBox_UserName.Location = new System.Drawing.Point(15, 98);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(153, 23);
            this.textBox_UserName.TabIndex = 5;
            // 
            // label_NTemCnt
            // 
            this.label_NTemCnt.AutoSize = true;
            this.label_NTemCnt.BackColor = System.Drawing.Color.Transparent;
            this.label_NTemCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NTemCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NTemCnt.Location = new System.Drawing.Point(3, 296);
            this.label_NTemCnt.Name = "label_NTemCnt";
            this.label_NTemCnt.Size = new System.Drawing.Size(179, 17);
            this.label_NTemCnt.TabIndex = 8;
            this.label_NTemCnt.Text = "Ainda não tem uma Conta?";
            // 
            // label_SignUP
            // 
            this.label_SignUP.AutoSize = true;
            this.label_SignUP.BackColor = System.Drawing.Color.Transparent;
            this.label_SignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_SignUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_SignUP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_SignUP.Location = new System.Drawing.Point(3, 313);
            this.label_SignUP.Name = "label_SignUP";
            this.label_SignUP.Size = new System.Drawing.Size(105, 17);
            this.label_SignUP.TabIndex = 7;
            this.label_SignUP.Text = "Increva-se aqui";
            this.label_SignUP.Click += new System.EventHandler(this.label_SignUp_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.ForeColor = System.Drawing.Color.White;
            this.button_sair.Location = new System.Drawing.Point(156, 0);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(24, 24);
            this.button_sair.TabIndex = 8;
            this.button_sair.Text = "x";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
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
            this.button_minimizar.TabIndex = 9;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = false;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // panel_Drag
            // 
            this.panel_Drag.BackColor = System.Drawing.Color.Transparent;
            this.panel_Drag.Location = new System.Drawing.Point(0, 0);
            this.panel_Drag.Name = "panel_Drag";
            this.panel_Drag.Size = new System.Drawing.Size(899, 27);
            this.panel_Drag.TabIndex = 10;
            this.panel_Drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseDown);
            this.panel_Drag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseMove);
            this.panel_Drag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseUp);
            // 
            // panel_layout
            // 
            this.panel_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_layout.Controls.Add(this.label_LOGIN);
            this.panel_layout.Controls.Add(this.label_SignUP);
            this.panel_layout.Controls.Add(this.label_NTemCnt);
            this.panel_layout.Controls.Add(this.button_minimizar);
            this.panel_layout.Controls.Add(this.button_sair);
            this.panel_layout.Controls.Add(this.button_Logar);
            this.panel_layout.Controls.Add(this.textBox_PassWord);
            this.panel_layout.Controls.Add(this.label_PassWord);
            this.panel_layout.Controls.Add(this.label_UserName);
            this.panel_layout.Controls.Add(this.textBox_UserName);
            this.panel_layout.Location = new System.Drawing.Point(720, 0);
            this.panel_layout.Name = "panel_layout";
            this.panel_layout.Size = new System.Drawing.Size(182, 403);
            this.panel_layout.TabIndex = 11;
            // 
            // label_LOGIN
            // 
            this.label_LOGIN.AutoSize = true;
            this.label_LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.label_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_LOGIN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_LOGIN.Location = new System.Drawing.Point(12, 46);
            this.label_LOGIN.Name = "label_LOGIN";
            this.label_LOGIN.Size = new System.Drawing.Size(61, 20);
            this.label_LOGIN.TabIndex = 12;
            this.label_LOGIN.Text = "LOGIN";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.ControlBox = false;
            this.Controls.Add(this.panel_layout);
            this.Controls.Add(this.panel_Drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quem quer ser milionário";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_layout.ResumeLayout(false);
            this.panel_layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.Button button_Logar;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_SignUP;
        private System.Windows.Forms.Label label_NTemCnt;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Panel panel_Drag;
        private System.Windows.Forms.Panel panel_layout;
        private System.Windows.Forms.Label label_LOGIN;
    }
}

