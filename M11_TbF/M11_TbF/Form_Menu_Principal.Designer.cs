namespace M11_TbF
{
    partial class Form_Menu_Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Estatísticas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Jogar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::M11_TbF.Properties.Resources.options_icon2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(540, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 25);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(28, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_utilizador
            // 
            this.label_utilizador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_utilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_utilizador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_utilizador.Location = new System.Drawing.Point(468, -1);
            this.label_utilizador.Name = "label_utilizador";
            this.label_utilizador.Size = new System.Drawing.Size(75, 25);
            this.label_utilizador.TabIndex = 4;
            this.label_utilizador.Text = "----";
            this.label_utilizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_utilizador.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Transparent;
            this.button_logout.BackgroundImage = global::M11_TbF.Properties.Resources.logout;
            this.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_logout.Location = new System.Drawing.Point(563, -1);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(27, 25);
            this.button_logout.TabIndex = 5;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::M11_TbF.Properties.Resources.backgroundDefault;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(204, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 149);
            this.panel1.TabIndex = 6;
            // 
            // Form_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.IMG63;
            this.ClientSize = new System.Drawing.Size(619, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_utilizador);
            this.Controls.Add(this.button3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 380);
            this.MinimumSize = new System.Drawing.Size(635, 380);
            this.Name = "Form_Menu_Principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_utilizador;
        private System.Windows.Forms.Button button_logout;

        public Form_Menu_Principal()
        {
        }

        private System.Windows.Forms.Panel panel1;
    }
}