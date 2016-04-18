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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Estatisticas));
            this.button_voltar = new System.Windows.Forms.Button();
            this.label_NivelMaximo = new System.Windows.Forms.Label();
            this.label_TotaldeDinheiroGanho = new System.Windows.Forms.Label();
            this.panel_layout = new System.Windows.Forms.Panel();
            this.label_logout = new System.Windows.Forms.Label();
            this.label_linha = new System.Windows.Forms.Label();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.panel_Drag = new System.Windows.Forms.Panel();
            this.panel_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Location = new System.Drawing.Point(104, 340);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(48, 34);
            this.button_voltar.TabIndex = 10;
            this.button_voltar.Text = "<-";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // label_NivelMaximo
            // 
            this.label_NivelMaximo.AutoSize = true;
            this.label_NivelMaximo.BackColor = System.Drawing.Color.Transparent;
            this.label_NivelMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NivelMaximo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NivelMaximo.Location = new System.Drawing.Point(12, 145);
            this.label_NivelMaximo.Name = "label_NivelMaximo";
            this.label_NivelMaximo.Size = new System.Drawing.Size(149, 17);
            this.label_NivelMaximo.TabIndex = 12;
            this.label_NivelMaximo.Text = "Nivel Máximo Atingido:";
            // 
            // label_TotaldeDinheiroGanho
            // 
            this.label_TotaldeDinheiroGanho.AutoSize = true;
            this.label_TotaldeDinheiroGanho.BackColor = System.Drawing.Color.Transparent;
            this.label_TotaldeDinheiroGanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_TotaldeDinheiroGanho.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_TotaldeDinheiroGanho.Location = new System.Drawing.Point(12, 212);
            this.label_TotaldeDinheiroGanho.Name = "label_TotaldeDinheiroGanho";
            this.label_TotaldeDinheiroGanho.Size = new System.Drawing.Size(140, 17);
            this.label_TotaldeDinheiroGanho.TabIndex = 15;
            this.label_TotaldeDinheiroGanho.Text = "Dinheiro total ganho:";
            // 
            // panel_layout
            // 
            this.panel_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_layout.Controls.Add(this.label_logout);
            this.panel_layout.Controls.Add(this.label_linha);
            this.panel_layout.Controls.Add(this.label_utilizador);
            this.panel_layout.Controls.Add(this.button_voltar);
            this.panel_layout.Controls.Add(this.label_TotaldeDinheiroGanho);
            this.panel_layout.Controls.Add(this.button_minimizar);
            this.panel_layout.Controls.Add(this.label_NivelMaximo);
            this.panel_layout.Controls.Add(this.button_sair);
            this.panel_layout.Location = new System.Drawing.Point(720, 0);
            this.panel_layout.Name = "panel_layout";
            this.panel_layout.Size = new System.Drawing.Size(182, 403);
            this.panel_layout.TabIndex = 22;
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
            this.label_logout.TabIndex = 24;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // label_linha
            // 
            this.label_linha.BackColor = System.Drawing.Color.White;
            this.label_linha.Location = new System.Drawing.Point(11, 107);
            this.label_linha.Name = "label_linha";
            this.label_linha.Size = new System.Drawing.Size(160, 1);
            this.label_linha.TabIndex = 25;
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
            this.label_utilizador.TabIndex = 23;
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
            // panel_Drag
            // 
            this.panel_Drag.BackColor = System.Drawing.Color.Transparent;
            this.panel_Drag.Location = new System.Drawing.Point(0, 0);
            this.panel_Drag.Name = "panel_Drag";
            this.panel_Drag.Size = new System.Drawing.Size(899, 27);
            this.panel_Drag.TabIndex = 23;
            this.panel_Drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseDown);
            this.panel_Drag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseMove);
            this.panel_Drag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseUp);
            // 
            // Form_Estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.FormBG;
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.ControlBox = false;
            this.Controls.Add(this.panel_layout);
            this.Controls.Add(this.panel_Drag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_Estatisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.Form_Estatisticas_Load);
            this.panel_layout.ResumeLayout(false);
            this.panel_layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label_NivelMaximo;
        private System.Windows.Forms.Label label_TotaldeDinheiroGanho;
        private System.Windows.Forms.Panel panel_layout;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label_linha;
        private System.Windows.Forms.Label label_utilizador;
        private System.Windows.Forms.Panel panel_Drag;
    }
}