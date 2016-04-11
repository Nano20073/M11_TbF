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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jogo));
            this.label_nivel = new System.Windows.Forms.Label();
            this.label_pergunta = new System.Windows.Forms.Label();
            this.label_r1 = new System.Windows.Forms.Label();
            this.label_r2 = new System.Windows.Forms.Label();
            this.label_r3 = new System.Windows.Forms.Label();
            this.label_r4 = new System.Windows.Forms.Label();
            this.pictureBox_MoneyTree = new System.Windows.Forms.PictureBox();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_tempo = new System.Windows.Forms.Label();
            this.timer_tempo = new System.Windows.Forms.Timer(this.components);
            this.timer_background_acertou = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Telefone = new System.Windows.Forms.Button();
            this.button_50_50 = new System.Windows.Forms.Button();
            this.button_ajuda_a_pessoas = new System.Windows.Forms.Button();
            this.timer_background_errou = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_sair = new System.Windows.Forms.Label();
            this.label_linha = new System.Windows.Forms.Label();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Ajudas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MoneyTree)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.button_minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.ForeColor = System.Drawing.Color.White;
            this.button_minimizar.Location = new System.Drawing.Point(132, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(24, 24);
            this.button_minimizar.TabIndex = 16;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = false;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.ForeColor = System.Drawing.Color.White;
            this.button_sair.Location = new System.Drawing.Point(155, 0);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(24, 24);
            this.button_sair.TabIndex = 17;
            this.button_sair.Text = "x";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // label_tempo
            // 
            this.label_tempo.AutoSize = true;
            this.label_tempo.BackColor = System.Drawing.Color.Transparent;
            this.label_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_tempo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_tempo.Location = new System.Drawing.Point(13, 137);
            this.label_tempo.Name = "label_tempo";
            this.label_tempo.Size = new System.Drawing.Size(126, 17);
            this.label_tempo.TabIndex = 18;
            this.label_tempo.Text = "Tempo Restante - ";
            // 
            // timer_tempo
            // 
            this.timer_tempo.Interval = 1000;
            this.timer_tempo.Tick += new System.EventHandler(this.timer_tempo_Tick);
            // 
            // timer_background_acertou
            // 
            this.timer_background_acertou.Interval = 500;
            this.timer_background_acertou.Tick += new System.EventHandler(this.timer_background_acertou_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox_MoneyTree);
            this.panel2.Controls.Add(this.label_nivel);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 197);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button_Telefone
            // 
            this.button_Telefone.BackgroundImage = global::M11_TbF.Properties.Resources.Telefone;
            this.button_Telefone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Telefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Telefone.Location = new System.Drawing.Point(65, 220);
            this.button_Telefone.Name = "button_Telefone";
            this.button_Telefone.Size = new System.Drawing.Size(53, 29);
            this.button_Telefone.TabIndex = 21;
            this.button_Telefone.UseVisualStyleBackColor = true;
            this.button_Telefone.Click += new System.EventHandler(this.button_Telefone_Click);
            // 
            // button_50_50
            // 
            this.button_50_50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_50_50.BackgroundImage")));
            this.button_50_50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_50_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_50_50.Location = new System.Drawing.Point(11, 220);
            this.button_50_50.Name = "button_50_50";
            this.button_50_50.Size = new System.Drawing.Size(53, 29);
            this.button_50_50.TabIndex = 20;
            this.button_50_50.UseVisualStyleBackColor = true;
            this.button_50_50.Click += new System.EventHandler(this.button_50_50_Click);
            // 
            // button_ajuda_a_pessoas
            // 
            this.button_ajuda_a_pessoas.BackgroundImage = global::M11_TbF.Properties.Resources.Ajuda_a_publico;
            this.button_ajuda_a_pessoas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ajuda_a_pessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajuda_a_pessoas.Location = new System.Drawing.Point(119, 220);
            this.button_ajuda_a_pessoas.Name = "button_ajuda_a_pessoas";
            this.button_ajuda_a_pessoas.Size = new System.Drawing.Size(53, 28);
            this.button_ajuda_a_pessoas.TabIndex = 19;
            this.button_ajuda_a_pessoas.UseVisualStyleBackColor = true;
            // 
            // timer_background_errou
            // 
            this.timer_background_errou.Interval = 500;
            this.timer_background_errou.Tick += new System.EventHandler(this.timer_background_errou_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button_Telefone);
            this.panel3.Controls.Add(this.label_Ajudas);
            this.panel3.Controls.Add(this.button_ajuda_a_pessoas);
            this.panel3.Controls.Add(this.button_50_50);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button_minimizar);
            this.panel3.Controls.Add(this.label_sair);
            this.panel3.Controls.Add(this.label_linha);
            this.panel3.Controls.Add(this.label_tempo);
            this.panel3.Controls.Add(this.button_sair);
            this.panel3.Controls.Add(this.label_utilizador);
            this.panel3.Location = new System.Drawing.Point(718, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 403);
            this.panel3.TabIndex = 20;
            // 
            // label_sair
            // 
            this.label_sair.AutoSize = true;
            this.label_sair.BackColor = System.Drawing.Color.Transparent;
            this.label_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_sair.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_sair.Location = new System.Drawing.Point(13, 92);
            this.label_sair.Name = "label_sair";
            this.label_sair.Size = new System.Drawing.Size(25, 13);
            this.label_sair.TabIndex = 20;
            this.label_sair.Text = "Sair";
            this.label_sair.Click += new System.EventHandler(this.label_sair_Click);
            // 
            // label_linha
            // 
            this.label_linha.BackColor = System.Drawing.Color.White;
            this.label_linha.Location = new System.Drawing.Point(11, 119);
            this.label_linha.Name = "label_linha";
            this.label_linha.Size = new System.Drawing.Size(160, 1);
            this.label_linha.TabIndex = 22;
            // 
            // label_utilizador
            // 
            this.label_utilizador.AutoSize = true;
            this.label_utilizador.BackColor = System.Drawing.Color.Transparent;
            this.label_utilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_utilizador.ForeColor = System.Drawing.Color.White;
            this.label_utilizador.Location = new System.Drawing.Point(12, 46);
            this.label_utilizador.Name = "label_utilizador";
            this.label_utilizador.Size = new System.Drawing.Size(33, 20);
            this.label_utilizador.TabIndex = 4;
            this.label_utilizador.Text = "----";
            this.label_utilizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 1);
            this.label1.TabIndex = 23;
            // 
            // label_Ajudas
            // 
            this.label_Ajudas.AutoSize = true;
            this.label_Ajudas.BackColor = System.Drawing.Color.Transparent;
            this.label_Ajudas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Ajudas.ForeColor = System.Drawing.Color.White;
            this.label_Ajudas.Location = new System.Drawing.Point(58, 190);
            this.label_Ajudas.Name = "label_Ajudas";
            this.label_Ajudas.Size = new System.Drawing.Size(60, 20);
            this.label_Ajudas.TabIndex = 24;
            this.label_Ajudas.Text = "Ajudas";
            this.label_Ajudas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "IN GAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.GameBG;
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_r4);
            this.Controls.Add(this.label_r3);
            this.Controls.Add(this.label_r2);
            this.Controls.Add(this.label_r1);
            this.Controls.Add(this.label_pergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MoneyTree)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label_tempo;
        private System.Windows.Forms.Timer timer_tempo;
        private System.Windows.Forms.Timer timer_background_acertou;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer_background_errou;
        private System.Windows.Forms.Button button_ajuda_a_pessoas;
        private System.Windows.Forms.Button button_50_50;
        private System.Windows.Forms.Button button_Telefone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_sair;
        private System.Windows.Forms.Label label_linha;
        private System.Windows.Forms.Label label_utilizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Ajudas;
        private System.Windows.Forms.Label label1;
    }
}