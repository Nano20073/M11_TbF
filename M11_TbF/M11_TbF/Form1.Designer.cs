namespace M11_TbF
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.button_Logar = new System.Windows.Forms.Button();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(12, 9);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(60, 13);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "UserName:";
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(12, 40);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(59, 13);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "PassWord:";
            // 
            // button_Logar
            // 
            this.button_Logar.Location = new System.Drawing.Point(200, 6);
            this.button_Logar.Name = "button_Logar";
            this.button_Logar.Size = new System.Drawing.Size(75, 51);
            this.button_Logar.TabIndex = 3;
            this.button_Logar.Text = "Login";
            this.button_Logar.UseVisualStyleBackColor = true;
            this.button_Logar.Click += new System.EventHandler(this.button_Logar_Click);
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(77, 37);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(100, 20);
            this.textBox_PassWord.TabIndex = 4;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(77, 6);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.IMG62;
            this.ClientSize = new System.Drawing.Size(604, 301);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.button_Logar);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.label_UserName);
            this.Name = "Form1";
            this.Text = "Quem quer ser milionário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.Button button_Logar;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.TextBox textBox_UserName;
    }
}

