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
            this.label_criar_conta = new System.Windows.Forms.Label();
            this.label_NTemCnt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_UserName.Location = new System.Drawing.Point(3, 11);
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
            this.label_PassWord.Location = new System.Drawing.Point(5, 34);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(77, 17);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "PassWord:";
            // 
            // button_Logar
            // 
            this.button_Logar.Location = new System.Drawing.Point(191, 11);
            this.button_Logar.Name = "button_Logar";
            this.button_Logar.Size = new System.Drawing.Size(84, 43);
            this.button_Logar.TabIndex = 3;
            this.button_Logar.Text = "Login";
            this.button_Logar.UseVisualStyleBackColor = true;
            this.button_Logar.Click += new System.EventHandler(this.button_Logar_Click);
            this.button_Logar.MouseEnter += new System.EventHandler(this.button_Logar_MouseEnter);
            this.button_Logar.MouseLeave += new System.EventHandler(this.button_Logar_MouseLeave);
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(85, 34);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.Size = new System.Drawing.Size(100, 20);
            this.textBox_PassWord.TabIndex = 4;
            this.textBox_PassWord.TextChanged += new System.EventHandler(this.textBox_PassWord_TextChanged);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(85, 11);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserName.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::M11_TbF.Properties.Resources.backgroundDefault;
            this.panel1.Controls.Add(this.label_NTemCnt);
            this.panel1.Controls.Add(this.label_criar_conta);
            this.panel1.Controls.Add(this.label_UserName);
            this.panel1.Controls.Add(this.label_PassWord);
            this.panel1.Controls.Add(this.textBox_UserName);
            this.panel1.Controls.Add(this.textBox_PassWord);
            this.panel1.Controls.Add(this.button_Logar);
            this.panel1.Location = new System.Drawing.Point(169, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 80);
            this.panel1.TabIndex = 7;
            // 
            // label_criar_conta
            // 
            this.label_criar_conta.AutoSize = true;
            this.label_criar_conta.BackColor = System.Drawing.Color.Transparent;
            this.label_criar_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_criar_conta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_criar_conta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_criar_conta.Location = new System.Drawing.Point(181, 57);
            this.label_criar_conta.Name = "label_criar_conta";
            this.label_criar_conta.Size = new System.Drawing.Size(105, 17);
            this.label_criar_conta.TabIndex = 7;
            this.label_criar_conta.Text = "Increva-se aqui";
            this.label_criar_conta.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_NTemCnt
            // 
            this.label_NTemCnt.AutoSize = true;
            this.label_NTemCnt.BackColor = System.Drawing.Color.Transparent;
            this.label_NTemCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NTemCnt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NTemCnt.Location = new System.Drawing.Point(5, 57);
            this.label_NTemCnt.Name = "label_NTemCnt";
            this.label_NTemCnt.Size = new System.Drawing.Size(179, 17);
            this.label_NTemCnt.TabIndex = 8;
            this.label_NTemCnt.Text = "Ainda não tem uma Conta?";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.IMG62;
            this.ClientSize = new System.Drawing.Size(619, 341);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 380);
            this.MinimumSize = new System.Drawing.Size(635, 380);
            this.Name = "Form_Login";
            this.Text = "Quem quer ser milionário";
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
    }
}

