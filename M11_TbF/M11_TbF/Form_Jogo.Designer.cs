namespace M11_TbF
{
    partial class Form_Jogo
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
            this.label_nivel = new System.Windows.Forms.Label();
            this.label_pergunta = new System.Windows.Forms.Label();
            this.label_r1 = new System.Windows.Forms.Label();
            this.label_r2 = new System.Windows.Forms.Label();
            this.label_r3 = new System.Windows.Forms.Label();
            this.label_r4 = new System.Windows.Forms.Label();
            this.pictureBox_MoneyTree = new System.Windows.Forms.PictureBox();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MoneyTree)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nivel
            // 
            this.label_nivel.AutoSize = true;
            this.label_nivel.BackColor = System.Drawing.Color.Transparent;
            this.label_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_nivel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_nivel.Location = new System.Drawing.Point(529, 44);
            this.label_nivel.Name = "label_nivel";
            this.label_nivel.Size = new System.Drawing.Size(88, 17);
            this.label_nivel.TabIndex = 6;
            this.label_nivel.Text = "Nivel Atual - ";
            // 
            // label_pergunta
            // 
            this.label_pergunta.BackColor = System.Drawing.Color.Transparent;
            this.label_pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_pergunta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_pergunta.Location = new System.Drawing.Point(93, 220);
            this.label_pergunta.Name = "label_pergunta";
            this.label_pergunta.Size = new System.Drawing.Size(524, 50);
            this.label_pergunta.TabIndex = 5;
            this.label_pergunta.Text = "Pergunta";
            this.label_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_r1
            // 
            this.label_r1.BackColor = System.Drawing.Color.Transparent;
            this.label_r1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_r1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_r1.Location = new System.Drawing.Point(86, 286);
            this.label_r1.Name = "label_r1";
            this.label_r1.Size = new System.Drawing.Size(247, 39);
            this.label_r1.TabIndex = 11;
            this.label_r1.Text = "Resposta1";
            this.label_r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_r1.Click += new System.EventHandler(this.label_r1_Click);
            // 
            // label_r2
            // 
            this.label_r2.BackColor = System.Drawing.Color.Transparent;
            this.label_r2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_r2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_r2.Location = new System.Drawing.Point(86, 333);
            this.label_r2.Name = "label_r2";
            this.label_r2.Size = new System.Drawing.Size(247, 39);
            this.label_r2.TabIndex = 12;
            this.label_r2.Text = "Resposta2";
            this.label_r2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_r2.Click += new System.EventHandler(this.label_r2_Click);
            // 
            // label_r3
            // 
            this.label_r3.BackColor = System.Drawing.Color.Transparent;
            this.label_r3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_r3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_r3.Location = new System.Drawing.Point(386, 286);
            this.label_r3.Name = "label_r3";
            this.label_r3.Size = new System.Drawing.Size(247, 39);
            this.label_r3.TabIndex = 13;
            this.label_r3.Text = "Resposta3";
            this.label_r3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_r3.Click += new System.EventHandler(this.label_r3_Click);
            // 
            // label_r4
            // 
            this.label_r4.BackColor = System.Drawing.Color.Transparent;
            this.label_r4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_r4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_r4.Location = new System.Drawing.Point(386, 332);
            this.label_r4.Name = "label_r4";
            this.label_r4.Size = new System.Drawing.Size(247, 36);
            this.label_r4.TabIndex = 14;
            this.label_r4.Text = "Resposta4";
            this.label_r4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_r4.Click += new System.EventHandler(this.label_r4_Click);
            // 
            // pictureBox_MoneyTree
            // 
            this.pictureBox_MoneyTree.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_MoneyTree.BackgroundImage = global::M11_TbF.Properties.Resources.nivel1;
            this.pictureBox_MoneyTree.Location = new System.Drawing.Point(0, -1);
            this.pictureBox_MoneyTree.Name = "pictureBox_MoneyTree";
            this.pictureBox_MoneyTree.Size = new System.Drawing.Size(144, 198);
            this.pictureBox_MoneyTree.TabIndex = 15;
            this.pictureBox_MoneyTree.TabStop = false;
            // 
            // button_minimizar
            // 
            this.button_minimizar.Location = new System.Drawing.Point(641, -1);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(27, 23);
            this.button_minimizar.TabIndex = 16;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.Red;
            this.button_sair.Location = new System.Drawing.Point(664, 0);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(28, 22);
            this.button_sair.TabIndex = 17;
            this.button_sair.Text = "x";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // Form_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.GameBG;
            this.ClientSize = new System.Drawing.Size(704, 382);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_minimizar);
            this.Controls.Add(this.pictureBox_MoneyTree);
            this.Controls.Add(this.label_r4);
            this.Controls.Add(this.label_r3);
            this.Controls.Add(this.label_r2);
            this.Controls.Add(this.label_r1);
            this.Controls.Add(this.label_nivel);
            this.Controls.Add(this.label_pergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 420);
            this.MinimumSize = new System.Drawing.Size(720, 420);
            this.Name = "Form_Jogo";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MoneyTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_pergunta;
        private System.Windows.Forms.Label label_nivel;
        private System.Windows.Forms.Label label_r1;
        private System.Windows.Forms.Label label_r2;
        private System.Windows.Forms.Label label_r3;
        private System.Windows.Forms.Label label_r4;
        private System.Windows.Forms.PictureBox pictureBox_MoneyTree;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Button button_sair;
    }
}