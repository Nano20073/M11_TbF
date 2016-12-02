namespace M11_TbF
{
    partial class Form_gestao
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
            this.textBox_R3 = new System.Windows.Forms.TextBox();
            this.textBox_R4 = new System.Windows.Forms.TextBox();
            this.textBox_R2 = new System.Windows.Forms.TextBox();
            this.textBox_R1 = new System.Windows.Forms.TextBox();
            this.textBox_Pergunta = new System.Windows.Forms.TextBox();
            this.label_Nova_Pergunta = new System.Windows.Forms.Label();
            this.label_Nova_Resposta1 = new System.Windows.Forms.Label();
            this.label_Nova_Resposta2 = new System.Windows.Forms.Label();
            this.label_Nova_Resposta3 = new System.Windows.Forms.Label();
            this.label_Nova_Resposta4 = new System.Windows.Forms.Label();
            this.comboBox_N = new System.Windows.Forms.ComboBox();
            this.label_Nivel = new System.Windows.Forms.Label();
            this.button_Criar = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label_Nova_Resposta_Correta = new System.Windows.Forms.Label();
            this.comboBox_RC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_R3
            // 
            this.textBox_R3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_R3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_R3.ForeColor = System.Drawing.Color.White;
            this.textBox_R3.Location = new System.Drawing.Point(161, 223);
            this.textBox_R3.Name = "textBox_R3";
            this.textBox_R3.Size = new System.Drawing.Size(152, 20);
            this.textBox_R3.TabIndex = 34;
            // 
            // textBox_R4
            // 
            this.textBox_R4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_R4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_R4.ForeColor = System.Drawing.Color.White;
            this.textBox_R4.Location = new System.Drawing.Point(161, 267);
            this.textBox_R4.Name = "textBox_R4";
            this.textBox_R4.Size = new System.Drawing.Size(152, 20);
            this.textBox_R4.TabIndex = 33;
            // 
            // textBox_R2
            // 
            this.textBox_R2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_R2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_R2.ForeColor = System.Drawing.Color.White;
            this.textBox_R2.Location = new System.Drawing.Point(161, 181);
            this.textBox_R2.Name = "textBox_R2";
            this.textBox_R2.Size = new System.Drawing.Size(152, 20);
            this.textBox_R2.TabIndex = 36;
            // 
            // textBox_R1
            // 
            this.textBox_R1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_R1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_R1.ForeColor = System.Drawing.Color.White;
            this.textBox_R1.Location = new System.Drawing.Point(161, 135);
            this.textBox_R1.Name = "textBox_R1";
            this.textBox_R1.Size = new System.Drawing.Size(152, 20);
            this.textBox_R1.TabIndex = 35;
            this.textBox_R1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_Pergunta
            // 
            this.textBox_Pergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_Pergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Pergunta.ForeColor = System.Drawing.Color.White;
            this.textBox_Pergunta.Location = new System.Drawing.Point(161, 71);
            this.textBox_Pergunta.Name = "textBox_Pergunta";
            this.textBox_Pergunta.Size = new System.Drawing.Size(354, 20);
            this.textBox_Pergunta.TabIndex = 37;
            // 
            // label_Nova_Pergunta
            // 
            this.label_Nova_Pergunta.AutoSize = true;
            this.label_Nova_Pergunta.BackColor = System.Drawing.Color.Transparent;
            this.label_Nova_Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nova_Pergunta.ForeColor = System.Drawing.Color.White;
            this.label_Nova_Pergunta.Location = new System.Drawing.Point(52, 69);
            this.label_Nova_Pergunta.Name = "label_Nova_Pergunta";
            this.label_Nova_Pergunta.Size = new System.Drawing.Size(67, 18);
            this.label_Nova_Pergunta.TabIndex = 38;
            this.label_Nova_Pergunta.Text = "Pergunta";
            this.label_Nova_Pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Nova_Pergunta.Click += new System.EventHandler(this.label_MudarUsername_Click);
            // 
            // label_Nova_Resposta1
            // 
            this.label_Nova_Resposta1.AutoSize = true;
            this.label_Nova_Resposta1.BackColor = System.Drawing.Color.Transparent;
            this.label_Nova_Resposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nova_Resposta1.ForeColor = System.Drawing.Color.White;
            this.label_Nova_Resposta1.Location = new System.Drawing.Point(35, 137);
            this.label_Nova_Resposta1.Name = "label_Nova_Resposta1";
            this.label_Nova_Resposta1.Size = new System.Drawing.Size(84, 18);
            this.label_Nova_Resposta1.TabIndex = 39;
            this.label_Nova_Resposta1.Text = "Resposta 1";
            this.label_Nova_Resposta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Nova_Resposta2
            // 
            this.label_Nova_Resposta2.AutoSize = true;
            this.label_Nova_Resposta2.BackColor = System.Drawing.Color.Transparent;
            this.label_Nova_Resposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nova_Resposta2.ForeColor = System.Drawing.Color.White;
            this.label_Nova_Resposta2.Location = new System.Drawing.Point(35, 183);
            this.label_Nova_Resposta2.Name = "label_Nova_Resposta2";
            this.label_Nova_Resposta2.Size = new System.Drawing.Size(84, 18);
            this.label_Nova_Resposta2.TabIndex = 40;
            this.label_Nova_Resposta2.Text = "Resposta 2";
            this.label_Nova_Resposta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Nova_Resposta3
            // 
            this.label_Nova_Resposta3.AutoSize = true;
            this.label_Nova_Resposta3.BackColor = System.Drawing.Color.Transparent;
            this.label_Nova_Resposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nova_Resposta3.ForeColor = System.Drawing.Color.White;
            this.label_Nova_Resposta3.Location = new System.Drawing.Point(35, 225);
            this.label_Nova_Resposta3.Name = "label_Nova_Resposta3";
            this.label_Nova_Resposta3.Size = new System.Drawing.Size(84, 18);
            this.label_Nova_Resposta3.TabIndex = 41;
            this.label_Nova_Resposta3.Text = "Resposta 3";
            this.label_Nova_Resposta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Nova_Resposta4
            // 
            this.label_Nova_Resposta4.AutoSize = true;
            this.label_Nova_Resposta4.BackColor = System.Drawing.Color.Transparent;
            this.label_Nova_Resposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nova_Resposta4.ForeColor = System.Drawing.Color.White;
            this.label_Nova_Resposta4.Location = new System.Drawing.Point(35, 269);
            this.label_Nova_Resposta4.Name = "label_Nova_Resposta4";
            this.label_Nova_Resposta4.Size = new System.Drawing.Size(84, 18);
            this.label_Nova_Resposta4.TabIndex = 42;
            this.label_Nova_Resposta4.Text = "Resposta 4";
            this.label_Nova_Resposta4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_N
            // 
            this.comboBox_N.FormattingEnabled = true;
            this.comboBox_N.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_N.Location = new System.Drawing.Point(161, 359);
            this.comboBox_N.Name = "comboBox_N";
            this.comboBox_N.Size = new System.Drawing.Size(121, 21);
            this.comboBox_N.TabIndex = 43;
            // 
            // label_Nivel
            // 
            this.label_Nivel.AutoSize = true;
            this.label_Nivel.BackColor = System.Drawing.Color.Transparent;
            this.label_Nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nivel.ForeColor = System.Drawing.Color.White;
            this.label_Nivel.Location = new System.Drawing.Point(35, 359);
            this.label_Nivel.Name = "label_Nivel";
            this.label_Nivel.Size = new System.Drawing.Size(40, 18);
            this.label_Nivel.TabIndex = 44;
            this.label_Nivel.Text = "Nivel";
            this.label_Nivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Criar
            // 
            this.button_Criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Criar.FlatAppearance.BorderSize = 3;
            this.button_Criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Criar.ForeColor = System.Drawing.Color.White;
            this.button_Criar.Location = new System.Drawing.Point(361, 137);
            this.button_Criar.Name = "button_Criar";
            this.button_Criar.Size = new System.Drawing.Size(154, 49);
            this.button_Criar.TabIndex = 45;
            this.button_Criar.Text = "Criar";
            this.button_Criar.UseVisualStyleBackColor = false;
            this.button_Criar.Click += new System.EventHandler(this.button_Criar_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Location = new System.Drawing.Point(686, 24);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(48, 34);
            this.button_voltar.TabIndex = 46;
            this.button_voltar.Text = "<-";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // label_Nova_Resposta_Correta
            // 
            this.label_Nova_Resposta_Correta.AutoSize = true;
            this.label_Nova_Resposta_Correta.BackColor = System.Drawing.Color.Transparent;
            this.label_Nova_Resposta_Correta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_Nova_Resposta_Correta.ForeColor = System.Drawing.Color.White;
            this.label_Nova_Resposta_Correta.Location = new System.Drawing.Point(35, 312);
            this.label_Nova_Resposta_Correta.Name = "label_Nova_Resposta_Correta";
            this.label_Nova_Resposta_Correta.Size = new System.Drawing.Size(126, 18);
            this.label_Nova_Resposta_Correta.TabIndex = 47;
            this.label_Nova_Resposta_Correta.Text = "Resposta Correta";
            this.label_Nova_Resposta_Correta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_RC
            // 
            this.comboBox_RC.FormattingEnabled = true;
            this.comboBox_RC.Items.AddRange(new object[] {
            "Resposta 1",
            "Resposta 2",
            "Resposta 3",
            "Resposta 4"});
            this.comboBox_RC.Location = new System.Drawing.Point(182, 309);
            this.comboBox_RC.Name = "comboBox_RC";
            this.comboBox_RC.Size = new System.Drawing.Size(121, 21);
            this.comboBox_RC.TabIndex = 48;
            // 
            // Form_gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(781, 445);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox_RC);
            this.Controls.Add(this.label_Nova_Resposta_Correta);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_Criar);
            this.Controls.Add(this.label_Nivel);
            this.Controls.Add(this.comboBox_N);
            this.Controls.Add(this.label_Nova_Resposta4);
            this.Controls.Add(this.label_Nova_Resposta3);
            this.Controls.Add(this.label_Nova_Resposta2);
            this.Controls.Add(this.label_Nova_Resposta1);
            this.Controls.Add(this.label_Nova_Pergunta);
            this.Controls.Add(this.textBox_Pergunta);
            this.Controls.Add(this.textBox_R2);
            this.Controls.Add(this.textBox_R1);
            this.Controls.Add(this.textBox_R3);
            this.Controls.Add(this.textBox_R4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_gestao";
            this.ShowInTaskbar = false;
            this.Text = "Form_gestao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_R3;
        private System.Windows.Forms.TextBox textBox_R4;
        private System.Windows.Forms.TextBox textBox_R2;
        private System.Windows.Forms.TextBox textBox_R1;
        private System.Windows.Forms.TextBox textBox_Pergunta;
        private System.Windows.Forms.Label label_Nova_Pergunta;
        private System.Windows.Forms.Label label_Nova_Resposta1;
        private System.Windows.Forms.Label label_Nova_Resposta2;
        private System.Windows.Forms.Label label_Nova_Resposta3;
        private System.Windows.Forms.Label label_Nova_Resposta4;
        private System.Windows.Forms.ComboBox comboBox_N;
        private System.Windows.Forms.Label label_Nivel;
        private System.Windows.Forms.Button button_Criar;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label_Nova_Resposta_Correta;
        private System.Windows.Forms.ComboBox comboBox_RC;
    }
}