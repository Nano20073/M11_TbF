namespace M11_TbF
{
    partial class Form5
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
            this.radioButton_r1 = new System.Windows.Forms.RadioButton();
            this.radioButton_r2 = new System.Windows.Forms.RadioButton();
            this.radioButton_r3 = new System.Windows.Forms.RadioButton();
            this.radioButton_r4 = new System.Windows.Forms.RadioButton();
            this.groupBox_respostas = new System.Windows.Forms.GroupBox();
            this.label_pergunta = new System.Windows.Forms.Label();
            this.label_nivel = new System.Windows.Forms.Label();
            this.button_submeter = new System.Windows.Forms.Button();
            this.groupBox_respostas.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_r1
            // 
            this.radioButton_r1.AutoSize = true;
            this.radioButton_r1.Location = new System.Drawing.Point(15, 23);
            this.radioButton_r1.Name = "radioButton_r1";
            this.radioButton_r1.Size = new System.Drawing.Size(85, 17);
            this.radioButton_r1.TabIndex = 0;
            this.radioButton_r1.TabStop = true;
            this.radioButton_r1.Text = "radioButton1";
            this.radioButton_r1.UseVisualStyleBackColor = true;
            // 
            // radioButton_r2
            // 
            this.radioButton_r2.AutoSize = true;
            this.radioButton_r2.Location = new System.Drawing.Point(15, 62);
            this.radioButton_r2.Name = "radioButton_r2";
            this.radioButton_r2.Size = new System.Drawing.Size(85, 17);
            this.radioButton_r2.TabIndex = 1;
            this.radioButton_r2.TabStop = true;
            this.radioButton_r2.Text = "radioButton2";
            this.radioButton_r2.UseVisualStyleBackColor = true;
            // 
            // radioButton_r3
            // 
            this.radioButton_r3.AutoSize = true;
            this.radioButton_r3.Location = new System.Drawing.Point(125, 23);
            this.radioButton_r3.Name = "radioButton_r3";
            this.radioButton_r3.Size = new System.Drawing.Size(85, 17);
            this.radioButton_r3.TabIndex = 2;
            this.radioButton_r3.TabStop = true;
            this.radioButton_r3.Text = "radioButton3";
            this.radioButton_r3.UseVisualStyleBackColor = true;
            // 
            // radioButton_r4
            // 
            this.radioButton_r4.AutoSize = true;
            this.radioButton_r4.Location = new System.Drawing.Point(125, 62);
            this.radioButton_r4.Name = "radioButton_r4";
            this.radioButton_r4.Size = new System.Drawing.Size(85, 17);
            this.radioButton_r4.TabIndex = 3;
            this.radioButton_r4.TabStop = true;
            this.radioButton_r4.Text = "radioButton4";
            this.radioButton_r4.UseVisualStyleBackColor = true;
            // 
            // groupBox_respostas
            // 
            this.groupBox_respostas.Controls.Add(this.radioButton_r1);
            this.groupBox_respostas.Controls.Add(this.radioButton_r4);
            this.groupBox_respostas.Controls.Add(this.radioButton_r3);
            this.groupBox_respostas.Controls.Add(this.radioButton_r2);
            this.groupBox_respostas.Location = new System.Drawing.Point(43, 67);
            this.groupBox_respostas.Name = "groupBox_respostas";
            this.groupBox_respostas.Size = new System.Drawing.Size(229, 127);
            this.groupBox_respostas.TabIndex = 4;
            this.groupBox_respostas.TabStop = false;
            // 
            // label_pergunta
            // 
            this.label_pergunta.AutoSize = true;
            this.label_pergunta.Location = new System.Drawing.Point(43, 25);
            this.label_pergunta.Name = "label_pergunta";
            this.label_pergunta.Size = new System.Drawing.Size(50, 13);
            this.label_pergunta.TabIndex = 5;
            this.label_pergunta.Text = "Pergunta";
            // 
            // label_nivel
            // 
            this.label_nivel.AutoSize = true;
            this.label_nivel.Location = new System.Drawing.Point(103, 9);
            this.label_nivel.Name = "label_nivel";
            this.label_nivel.Size = new System.Drawing.Size(40, 13);
            this.label_nivel.TabIndex = 6;
            this.label_nivel.Text = "Nivel - ";
            // 
            // button_submeter
            // 
            this.button_submeter.Location = new System.Drawing.Point(90, 200);
            this.button_submeter.Name = "button_submeter";
            this.button_submeter.Size = new System.Drawing.Size(120, 31);
            this.button_submeter.TabIndex = 7;
            this.button_submeter.Text = "Submeter";
            this.button_submeter.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 284);
            this.Controls.Add(this.button_submeter);
            this.Controls.Add(this.label_nivel);
            this.Controls.Add(this.label_pergunta);
            this.Controls.Add(this.groupBox_respostas);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox_respostas.ResumeLayout(false);
            this.groupBox_respostas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_r1;
        private System.Windows.Forms.RadioButton radioButton_r2;
        private System.Windows.Forms.RadioButton radioButton_r3;
        private System.Windows.Forms.RadioButton radioButton_r4;
        private System.Windows.Forms.GroupBox groupBox_respostas;
        private System.Windows.Forms.Label label_pergunta;
        private System.Windows.Forms.Label label_nivel;
        private System.Windows.Forms.Button button_submeter;
    }
}