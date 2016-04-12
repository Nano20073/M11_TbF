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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu_Principal));
            this.button_sair = new System.Windows.Forms.Button();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.panel_Drag = new System.Windows.Forms.Panel();
            this.panel_layout = new System.Windows.Forms.Panel();
            this.button_Jogar = new System.Windows.Forms.Button();
            this.button_Estatisticas = new System.Windows.Forms.Button();
            this.button_Opcoes = new System.Windows.Forms.Button();
            this.label_logout = new System.Windows.Forms.Label();
            this.label_linha = new System.Windows.Forms.Label();
            this.panel_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_sair.ForeColor = System.Drawing.Color.White;
            this.button_sair.Location = new System.Drawing.Point(156, 0);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(24, 24);
            this.button_sair.TabIndex = 3;
            this.button_sair.Text = "x";
            this.button_sair.UseVisualStyleBackColor = false;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
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
            // button_minimizar
            // 
            this.button_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimizar.ForeColor = System.Drawing.Color.White;
            this.button_minimizar.Location = new System.Drawing.Point(133, 0);
            this.button_minimizar.Name = "button_minimizar";
            this.button_minimizar.Size = new System.Drawing.Size(24, 24);
            this.button_minimizar.TabIndex = 17;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = true;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // panel_Drag
            // 
            this.panel_Drag.BackColor = System.Drawing.Color.Transparent;
            this.panel_Drag.Location = new System.Drawing.Point(0, 0);
            this.panel_Drag.Name = "panel_Drag";
            this.panel_Drag.Size = new System.Drawing.Size(899, 27);
            this.panel_Drag.TabIndex = 18;
            this.panel_Drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseDown);
            this.panel_Drag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseMove);
            this.panel_Drag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseUp);
            // 
            // panel_layout
            // 
            this.panel_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_layout.Controls.Add(this.button_Jogar);
            this.panel_layout.Controls.Add(this.button_Estatisticas);
            this.panel_layout.Controls.Add(this.button_Opcoes);
            this.panel_layout.Controls.Add(this.label_logout);
            this.panel_layout.Controls.Add(this.label_linha);
            this.panel_layout.Controls.Add(this.label_utilizador);
            this.panel_layout.Controls.Add(this.button_minimizar);
            this.panel_layout.Controls.Add(this.button_sair);
            this.panel_layout.Location = new System.Drawing.Point(720, 0);
            this.panel_layout.Name = "panel_layout";
            this.panel_layout.Size = new System.Drawing.Size(182, 403);
            this.panel_layout.TabIndex = 19;
            // 
            // button_Jogar
            // 
            this.button_Jogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Jogar.ForeColor = System.Drawing.Color.White;
            this.button_Jogar.Location = new System.Drawing.Point(16, 129);
            this.button_Jogar.Name = "button_Jogar";
            this.button_Jogar.Size = new System.Drawing.Size(153, 40);
            this.button_Jogar.TabIndex = 22;
            this.button_Jogar.Text = "Jogar";
            this.button_Jogar.UseVisualStyleBackColor = false;
            this.button_Jogar.Click += new System.EventHandler(this.button_Jogar_Click);
            // 
            // button_Estatisticas
            // 
            this.button_Estatisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Estatisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Estatisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Estatisticas.ForeColor = System.Drawing.Color.White;
            this.button_Estatisticas.Location = new System.Drawing.Point(16, 191);
            this.button_Estatisticas.Name = "button_Estatisticas";
            this.button_Estatisticas.Size = new System.Drawing.Size(153, 40);
            this.button_Estatisticas.TabIndex = 21;
            this.button_Estatisticas.Text = "Estatisticas";
            this.button_Estatisticas.UseVisualStyleBackColor = false;
            this.button_Estatisticas.Click += new System.EventHandler(this.button_Estatisticas_Click);
            // 
            // button_Opcoes
            // 
            this.button_Opcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Opcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Opcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Opcoes.ForeColor = System.Drawing.Color.White;
            this.button_Opcoes.Location = new System.Drawing.Point(16, 253);
            this.button_Opcoes.Name = "button_Opcoes";
            this.button_Opcoes.Size = new System.Drawing.Size(153, 40);
            this.button_Opcoes.TabIndex = 20;
            this.button_Opcoes.Text = "Opções";
            this.button_Opcoes.UseVisualStyleBackColor = false;
            this.button_Opcoes.Click += new System.EventHandler(this.button_Opcoes_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.BackColor = System.Drawing.Color.Transparent;
            this.label_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_logout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_logout.Location = new System.Drawing.Point(13, 76);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(40, 13);
            this.label_logout.TabIndex = 20;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // label_linha
            // 
            this.label_linha.BackColor = System.Drawing.Color.White;
            this.label_linha.Location = new System.Drawing.Point(11, 107);
            this.label_linha.Name = "label_linha";
            this.label_linha.Size = new System.Drawing.Size(160, 1);
            this.label_linha.TabIndex = 22;
            // 
            // Form_Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.Controls.Add(this.panel_layout);
            this.Controls.Add(this.panel_Drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel_layout.ResumeLayout(false);
            this.panel_layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_utilizador;

        public Form_Menu_Principal()
        {
        }
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Panel panel_Drag;
        private System.Windows.Forms.Panel panel_layout;
        private System.Windows.Forms.Label label_linha;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Button button_Estatisticas;
        private System.Windows.Forms.Button button_Opcoes;
        private System.Windows.Forms.Button button_Jogar;
    }
}