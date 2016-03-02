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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jogo));
            this.label_nivel = new System.Windows.Forms.Label();
            this.label_pergunta = new System.Windows.Forms.Label();
            this.button_R1 = new System.Windows.Forms.Button();
            this.button_R2 = new System.Windows.Forms.Button();
            this.button_R3 = new System.Windows.Forms.Button();
            this.button_R4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nivel
            // 
            this.label_nivel.AutoSize = true;
            this.label_nivel.BackColor = System.Drawing.Color.Transparent;
            this.label_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_nivel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_nivel.Location = new System.Drawing.Point(12, 9);
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
            this.label_pergunta.Image = global::M11_TbF.Properties.Resources.quiz_question;
            this.label_pergunta.Location = new System.Drawing.Point(127, 71);
            this.label_pergunta.Name = "label_pergunta";
            this.label_pergunta.Size = new System.Drawing.Size(349, 79);
            this.label_pergunta.TabIndex = 5;
            this.label_pergunta.Text = "Pergunta";
            this.label_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_R1
            // 
            this.button_R1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_R1.BackgroundImage")));
            this.button_R1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_R1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_R1.Location = new System.Drawing.Point(142, 177);
            this.button_R1.Name = "button_R1";
            this.button_R1.Size = new System.Drawing.Size(138, 41);
            this.button_R1.TabIndex = 7;
            this.button_R1.Text = "Resposta1";
            this.button_R1.UseVisualStyleBackColor = true;
            this.button_R1.Click += new System.EventHandler(this.button_R1_Click);
            // 
            // button_R2
            // 
            this.button_R2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_R2.BackgroundImage")));
            this.button_R2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_R2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_R2.Location = new System.Drawing.Point(142, 239);
            this.button_R2.Name = "button_R2";
            this.button_R2.Size = new System.Drawing.Size(138, 41);
            this.button_R2.TabIndex = 8;
            this.button_R2.Text = "Resposta2";
            this.button_R2.UseVisualStyleBackColor = true;
            this.button_R2.Click += new System.EventHandler(this.button_R2_Click);
            // 
            // button_R3
            // 
            this.button_R3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_R3.BackgroundImage")));
            this.button_R3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_R3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_R3.Location = new System.Drawing.Point(325, 177);
            this.button_R3.Name = "button_R3";
            this.button_R3.Size = new System.Drawing.Size(138, 41);
            this.button_R3.TabIndex = 9;
            this.button_R3.Text = "Resposta3";
            this.button_R3.UseVisualStyleBackColor = true;
            this.button_R3.Click += new System.EventHandler(this.button_R3_Click);
            // 
            // button_R4
            // 
            this.button_R4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_R4.BackgroundImage")));
            this.button_R4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_R4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_R4.Location = new System.Drawing.Point(325, 239);
            this.button_R4.Name = "button_R4";
            this.button_R4.Size = new System.Drawing.Size(138, 41);
            this.button_R4.TabIndex = 10;
            this.button_R4.Text = "Resposta4";
            this.button_R4.UseVisualStyleBackColor = true;
            this.button_R4.Click += new System.EventHandler(this.button_R4_Click);
            // 
            // Form_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.IMG62;
            this.ClientSize = new System.Drawing.Size(619, 341);
            this.Controls.Add(this.button_R4);
            this.Controls.Add(this.button_R3);
            this.Controls.Add(this.button_R2);
            this.Controls.Add(this.button_R1);
            this.Controls.Add(this.label_nivel);
            this.Controls.Add(this.label_pergunta);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 380);
            this.MinimumSize = new System.Drawing.Size(635, 380);
            this.Name = "Form_Jogo";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_pergunta;
        private System.Windows.Forms.Label label_nivel;
        private System.Windows.Forms.Button button_R1;
        private System.Windows.Forms.Button button_R2;
        private System.Windows.Forms.Button button_R3;
        private System.Windows.Forms.Button button_R4;
    }
}