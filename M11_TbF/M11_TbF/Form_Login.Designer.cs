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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.button_Logar = new System.Windows.Forms.Button();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_NTemCnt = new System.Windows.Forms.Label();
            this.label_criar_conta = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_UserName.Location = new System.Drawing.Point(7, 16);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(79, 17);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "UserName:";
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.BackColor = System.Drawing.Color.Transparent;
            this.label_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_PassWord.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_PassWord.Location = new System.Drawing.Point(8, 46);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(77, 17);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "PassWord:";
            // 
            // button_Logar
            // 
            this.button_Logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Logar.Location = new System.Drawing.Point(203, 13);
            this.button_Logar.Name = "button_Logar";
            this.button_Logar.Size = new System.Drawing.Size(83, 54);
            this.button_Logar.TabIndex = 3;
            this.button_Logar.Text = "Login";
            this.button_Logar.UseVisualStyleBackColor = true;
            this.button_Logar.Click += new System.EventHandler(this.button_Logar_Click);
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_PassWord.Location = new System.Drawing.Point(97, 43);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.Size = new System.Drawing.Size(100, 23);
            this.textBox_PassWord.TabIndex = 4;
            this.textBox_PassWord.TextChanged += new System.EventHandler(this.textBox_PassWord_TextChanged);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox_UserName.Location = new System.Drawing.Point(97, 13);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(100, 23);
            this.textBox_UserName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::M11_TbF.Properties.Resources.backgroundDefault;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label_NTemCnt);
            this.panel1.Controls.Add(this.label_criar_conta);
            this.panel1.Controls.Add(this.label_UserName);
            this.panel1.Controls.Add(this.label_PassWord);
            this.panel1.Controls.Add(this.textBox_UserName);
            this.panel1.Controls.Add(this.textBox_PassWord);
            this.panel1.Controls.Add(this.button_Logar);
            this.panel1.Location = new System.Drawing.Point(230, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 103);
            this.panel1.TabIndex = 7;
            // 
            // label_NTemCnt
            // 
            this.label_NTemCnt.AutoSize = true;
            this.label_NTemCnt.BackColor = System.Drawing.Color.Transparent;
            this.label_NTemCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NTemCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NTemCnt.Location = new System.Drawing.Point(7, 80);
            this.label_NTemCnt.Name = "label_NTemCnt";
            this.label_NTemCnt.Size = new System.Drawing.Size(179, 17);
            this.label_NTemCnt.TabIndex = 8;
            this.label_NTemCnt.Text = "Ainda não tem uma Conta?";
            // 
            // label_criar_conta
            // 
            this.label_criar_conta.AutoSize = true;
            this.label_criar_conta.BackColor = System.Drawing.Color.Transparent;
            this.label_criar_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_criar_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_criar_conta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_criar_conta.Location = new System.Drawing.Point(184, 80);
            this.label_criar_conta.Name = "label_criar_conta";
            this.label_criar_conta.Size = new System.Drawing.Size(105, 17);
            this.label_criar_conta.TabIndex = 7;
            this.label_criar_conta.Text = "Increva-se aqui";
            this.label_criar_conta.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Red;
            this.button_sair.Location = new System.Drawing.Point(676, 0);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(28, 22);
            this.button_sair.TabIndex = 8;
            this.button_sair.Text = "x";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // button_minimizar
            // 
            this.button_minimizar.Location = new System.Drawing.Point(652, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(27, 23);
            this.button_minimizar.TabIndex = 9;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.FormBG;
            this.ClientSize = new System.Drawing.Size(704, 366);
            this.ControlBox = false;
            this.Controls.Add(this.button_minimizar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 404);
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quem quer ser milionário";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.Button button_Logar;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_criar_conta;
        private System.Windows.Forms.Label label_NTemCnt;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_minimizar;
    }
}

