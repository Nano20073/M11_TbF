namespace M11_TbF
{
    partial class Form_Estatisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.label_NivelMaximo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nivel Máximo Atigindo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel Mínimo Atigindo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de jogos:";
            // 
            // button_sair
            // 
            this.button_sair.BackgroundImage = global::M11_TbF.Properties.Resources.botão_voltar;
            this.button_sair.Location = new System.Drawing.Point(114, 187);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(48, 34);
            this.button_sair.TabIndex = 10;
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // label_utilizador
            // 
            this.label_utilizador.AutoSize = true;
            this.label_utilizador.BackColor = System.Drawing.Color.Transparent;
            this.label_utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_utilizador.ForeColor = System.Drawing.Color.Transparent;
            this.label_utilizador.Location = new System.Drawing.Point(178, 9);
            this.label_utilizador.Name = "label_utilizador";
            this.label_utilizador.Size = new System.Drawing.Size(28, 17);
            this.label_utilizador.TabIndex = 11;
            this.label_utilizador.Text = "----";
            this.label_utilizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NivelMaximo
            // 
            this.label_NivelMaximo.AutoSize = true;
            this.label_NivelMaximo.BackColor = System.Drawing.Color.Transparent;
            this.label_NivelMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NivelMaximo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NivelMaximo.Location = new System.Drawing.Point(178, 43);
            this.label_NivelMaximo.Name = "label_NivelMaximo";
            this.label_NivelMaximo.Size = new System.Drawing.Size(13, 17);
            this.label_NivelMaximo.TabIndex = 12;
            this.label_NivelMaximo.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username usado:";
            // 
            // Form_Estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.backgroundDefault;
            this.ClientSize = new System.Drawing.Size(286, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_NivelMaximo);
            this.Controls.Add(this.label_utilizador);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Estatisticas";
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_utilizador;
        private System.Windows.Forms.Label label_NivelMaximo;
        private System.Windows.Forms.Label label4;
    }
}