﻿namespace M11_TbF
{
    partial class Form_Opcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Opcoes));
            this.panel_layout = new System.Windows.Forms.Panel();
            this.label_lgout = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_AlterarPassword = new System.Windows.Forms.Button();
            this.button_AlterarUsername = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ConfirmarNovaPassword = new System.Windows.Forms.TextBox();
            this.textBox_NovaPassword = new System.Windows.Forms.TextBox();
            this.label_ConfirmarMudarPassword = new System.Windows.Forms.Label();
            this.label_MudarPassword = new System.Windows.Forms.Label();
            this.label_MudarPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_MudarUsername = new System.Windows.Forms.Label();
            this.textBox_ConfirmarNovoUsername = new System.Windows.Forms.TextBox();
            this.label_ConfirmarNovoUsername = new System.Windows.Forms.Label();
            this.textBox_NovoUtilizador = new System.Windows.Forms.TextBox();
            this.label_NovoUsername = new System.Windows.Forms.Label();
            this.label_linha = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.button_voltar = new System.Windows.Forms.Button();
            this.label_utilizador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_OPCOES = new System.Windows.Forms.Label();
            this.button_minimizar = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.panel_Drag = new System.Windows.Forms.Panel();
            this.panel_MiniSair = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_ToolTipUsername = new System.Windows.Forms.Label();
            this.label_ToolTipPassword = new System.Windows.Forms.Label();
            this.panel_layout.SuspendLayout();
            this.panel_Drag.SuspendLayout();
            this.panel_MiniSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_layout
            // 
            this.panel_layout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_layout.Controls.Add(this.label_ToolTipPassword);
            this.panel_layout.Controls.Add(this.label_ToolTipUsername);
            this.panel_layout.Controls.Add(this.label_lgout);
            this.panel_layout.Controls.Add(this.label4);
            this.panel_layout.Controls.Add(this.label3);
            this.panel_layout.Controls.Add(this.button_Reset);
            this.panel_layout.Controls.Add(this.button_AlterarPassword);
            this.panel_layout.Controls.Add(this.button_AlterarUsername);
            this.panel_layout.Controls.Add(this.label6);
            this.panel_layout.Controls.Add(this.textBox_ConfirmarNovaPassword);
            this.panel_layout.Controls.Add(this.textBox_NovaPassword);
            this.panel_layout.Controls.Add(this.label_ConfirmarMudarPassword);
            this.panel_layout.Controls.Add(this.label_MudarPassword);
            this.panel_layout.Controls.Add(this.label_MudarPass);
            this.panel_layout.Controls.Add(this.label2);
            this.panel_layout.Controls.Add(this.label_MudarUsername);
            this.panel_layout.Controls.Add(this.textBox_ConfirmarNovoUsername);
            this.panel_layout.Controls.Add(this.label_ConfirmarNovoUsername);
            this.panel_layout.Controls.Add(this.textBox_NovoUtilizador);
            this.panel_layout.Controls.Add(this.label_NovoUsername);
            this.panel_layout.Controls.Add(this.label_linha);
            this.panel_layout.Controls.Add(this.label_logout);
            this.panel_layout.Controls.Add(this.button_voltar);
            this.panel_layout.Controls.Add(this.label_utilizador);
            this.panel_layout.Controls.Add(this.label1);
            this.panel_layout.Controls.Add(this.label_OPCOES);
            this.panel_layout.Location = new System.Drawing.Point(720, 0);
            this.panel_layout.Name = "panel_layout";
            this.panel_layout.Size = new System.Drawing.Size(182, 404);
            this.panel_layout.TabIndex = 20;
            // 
            // label_lgout
            // 
            this.label_lgout.AutoSize = true;
            this.label_lgout.BackColor = System.Drawing.Color.Transparent;
            this.label_lgout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_lgout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_lgout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_lgout.Location = new System.Drawing.Point(13, 76);
            this.label_lgout.Name = "label_lgout";
            this.label_lgout.Size = new System.Drawing.Size(40, 13);
            this.label_lgout.TabIndex = 45;
            this.label_lgout.Text = "Logout";
            this.label_lgout.Click += new System.EventHandler(this.label_lgout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(7, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 68);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nota: Se você fizer reset\r\nirá perder todo o seu \r\nprogresso.\r\nTem a certeza?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Reset";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Reset.FlatAppearance.BorderSize = 3;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Reset.ForeColor = System.Drawing.Color.White;
            this.button_Reset.Location = new System.Drawing.Point(14, 657);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(154, 49);
            this.button_Reset.TabIndex = 20;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_AlterarPassword
            // 
            this.button_AlterarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_AlterarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AlterarPassword.FlatAppearance.BorderSize = 3;
            this.button_AlterarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AlterarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_AlterarPassword.ForeColor = System.Drawing.Color.White;
            this.button_AlterarPassword.Location = new System.Drawing.Point(15, 484);
            this.button_AlterarPassword.Name = "button_AlterarPassword";
            this.button_AlterarPassword.Size = new System.Drawing.Size(154, 49);
            this.button_AlterarPassword.TabIndex = 41;
            this.button_AlterarPassword.Text = "Alterar";
            this.button_AlterarPassword.UseVisualStyleBackColor = false;
            this.button_AlterarPassword.Click += new System.EventHandler(this.button_AlterarPassword_Click);
            // 
            // button_AlterarUsername
            // 
            this.button_AlterarUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_AlterarUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AlterarUsername.FlatAppearance.BorderSize = 3;
            this.button_AlterarUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AlterarUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_AlterarUsername.ForeColor = System.Drawing.Color.White;
            this.button_AlterarUsername.Location = new System.Drawing.Point(15, 283);
            this.button_AlterarUsername.Name = "button_AlterarUsername";
            this.button_AlterarUsername.Size = new System.Drawing.Size(154, 49);
            this.button_AlterarUsername.TabIndex = 40;
            this.button_AlterarUsername.Text = "Alterar";
            this.button_AlterarUsername.UseVisualStyleBackColor = false;
            this.button_AlterarUsername.Click += new System.EventHandler(this.button_AlterarUsername_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 1);
            this.label6.TabIndex = 35;
            // 
            // textBox_ConfirmarNovaPassword
            // 
            this.textBox_ConfirmarNovaPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_ConfirmarNovaPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConfirmarNovaPassword.ForeColor = System.Drawing.Color.White;
            this.textBox_ConfirmarNovaPassword.Location = new System.Drawing.Point(17, 458);
            this.textBox_ConfirmarNovaPassword.Name = "textBox_ConfirmarNovaPassword";
            this.textBox_ConfirmarNovaPassword.Size = new System.Drawing.Size(152, 20);
            this.textBox_ConfirmarNovaPassword.TabIndex = 39;
            // 
            // textBox_NovaPassword
            // 
            this.textBox_NovaPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_NovaPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NovaPassword.ForeColor = System.Drawing.Color.White;
            this.textBox_NovaPassword.Location = new System.Drawing.Point(17, 404);
            this.textBox_NovaPassword.Name = "textBox_NovaPassword";
            this.textBox_NovaPassword.Size = new System.Drawing.Size(152, 20);
            this.textBox_NovaPassword.TabIndex = 38;
            // 
            // label_ConfirmarMudarPassword
            // 
            this.label_ConfirmarMudarPassword.AutoSize = true;
            this.label_ConfirmarMudarPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_ConfirmarMudarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_ConfirmarMudarPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_ConfirmarMudarPassword.Location = new System.Drawing.Point(14, 438);
            this.label_ConfirmarMudarPassword.Name = "label_ConfirmarMudarPassword";
            this.label_ConfirmarMudarPassword.Size = new System.Drawing.Size(138, 17);
            this.label_ConfirmarMudarPassword.TabIndex = 37;
            this.label_ConfirmarMudarPassword.Text = "Confirmar Password:";
            // 
            // label_MudarPassword
            // 
            this.label_MudarPassword.AutoSize = true;
            this.label_MudarPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_MudarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_MudarPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_MudarPassword.Location = new System.Drawing.Point(14, 384);
            this.label_MudarPassword.Name = "label_MudarPassword";
            this.label_MudarPassword.Size = new System.Drawing.Size(110, 17);
            this.label_MudarPassword.TabIndex = 36;
            this.label_MudarPassword.Text = "Nova Password:";
            // 
            // label_MudarPass
            // 
            this.label_MudarPass.AutoSize = true;
            this.label_MudarPass.BackColor = System.Drawing.Color.Transparent;
            this.label_MudarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_MudarPass.ForeColor = System.Drawing.Color.White;
            this.label_MudarPass.Location = new System.Drawing.Point(32, 353);
            this.label_MudarPass.Name = "label_MudarPass";
            this.label_MudarPass.Size = new System.Drawing.Size(121, 18);
            this.label_MudarPass.TabIndex = 35;
            this.label_MudarPass.Text = "Mudar Password";
            this.label_MudarPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 1);
            this.label2.TabIndex = 34;
            // 
            // label_MudarUsername
            // 
            this.label_MudarUsername.AutoSize = true;
            this.label_MudarUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_MudarUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label_MudarUsername.ForeColor = System.Drawing.Color.White;
            this.label_MudarUsername.Location = new System.Drawing.Point(31, 152);
            this.label_MudarUsername.Name = "label_MudarUsername";
            this.label_MudarUsername.Size = new System.Drawing.Size(123, 18);
            this.label_MudarUsername.TabIndex = 33;
            this.label_MudarUsername.Text = "Mudar Username";
            this.label_MudarUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ConfirmarNovoUsername
            // 
            this.textBox_ConfirmarNovoUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_ConfirmarNovoUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConfirmarNovoUsername.ForeColor = System.Drawing.Color.White;
            this.textBox_ConfirmarNovoUsername.Location = new System.Drawing.Point(17, 257);
            this.textBox_ConfirmarNovoUsername.Name = "textBox_ConfirmarNovoUsername";
            this.textBox_ConfirmarNovoUsername.Size = new System.Drawing.Size(152, 20);
            this.textBox_ConfirmarNovoUsername.TabIndex = 32;
            // 
            // label_ConfirmarNovoUsername
            // 
            this.label_ConfirmarNovoUsername.AutoSize = true;
            this.label_ConfirmarNovoUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_ConfirmarNovoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_ConfirmarNovoUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_ConfirmarNovoUsername.Location = new System.Drawing.Point(14, 237);
            this.label_ConfirmarNovoUsername.Name = "label_ConfirmarNovoUsername";
            this.label_ConfirmarNovoUsername.Size = new System.Drawing.Size(142, 17);
            this.label_ConfirmarNovoUsername.TabIndex = 30;
            this.label_ConfirmarNovoUsername.Text = "Confirmar Username:";
            // 
            // textBox_NovoUtilizador
            // 
            this.textBox_NovoUtilizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox_NovoUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NovoUtilizador.ForeColor = System.Drawing.Color.White;
            this.textBox_NovoUtilizador.Location = new System.Drawing.Point(17, 203);
            this.textBox_NovoUtilizador.Name = "textBox_NovoUtilizador";
            this.textBox_NovoUtilizador.Size = new System.Drawing.Size(152, 20);
            this.textBox_NovoUtilizador.TabIndex = 31;
            // 
            // label_NovoUsername
            // 
            this.label_NovoUsername.AutoSize = true;
            this.label_NovoUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_NovoUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_NovoUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_NovoUsername.Location = new System.Drawing.Point(14, 183);
            this.label_NovoUsername.Name = "label_NovoUsername";
            this.label_NovoUsername.Size = new System.Drawing.Size(114, 17);
            this.label_NovoUsername.TabIndex = 29;
            this.label_NovoUsername.Text = "Novo Username:";
            // 
            // label_linha
            // 
            this.label_linha.BackColor = System.Drawing.Color.White;
            this.label_linha.Location = new System.Drawing.Point(11, 107);
            this.label_linha.Name = "label_linha";
            this.label_linha.Size = new System.Drawing.Size(160, 1);
            this.label_linha.TabIndex = 28;
            // 
            // label_logout
            // 
            this.label_logout.Location = new System.Drawing.Point(0, 0);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(100, 23);
            this.label_logout.TabIndex = 46;
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Location = new System.Drawing.Point(104, 728);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(48, 34);
            this.button_voltar.TabIndex = 27;
            this.button_voltar.Text = "<-";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
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
            this.label_utilizador.TabIndex = 25;
            this.label_utilizador.Text = "----";
            this.label_utilizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 1);
            this.label1.TabIndex = 26;
            // 
            // label_OPCOES
            // 
            this.label_OPCOES.AutoSize = true;
            this.label_OPCOES.BackColor = System.Drawing.Color.Transparent;
            this.label_OPCOES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_OPCOES.ForeColor = System.Drawing.Color.White;
            this.label_OPCOES.Location = new System.Drawing.Point(51, 115);
            this.label_OPCOES.Name = "label_OPCOES";
            this.label_OPCOES.Size = new System.Drawing.Size(80, 20);
            this.label_OPCOES.TabIndex = 25;
            this.label_OPCOES.Text = "OPÇÕES";
            this.label_OPCOES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button_minimizar.TabIndex = 17;
            this.button_minimizar.Text = "_";
            this.button_minimizar.UseVisualStyleBackColor = false;
            this.button_minimizar.Click += new System.EventHandler(this.button_minimizar_Click);
            // 
            // button_sair
            // 
            this.button_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_sair.ForeColor = System.Drawing.Color.White;
            this.button_sair.Location = new System.Drawing.Point(155, 0);
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
            this.panel_Drag.Controls.Add(this.panel_MiniSair);
            this.panel_Drag.Location = new System.Drawing.Point(0, 0);
            this.panel_Drag.Name = "panel_Drag";
            this.panel_Drag.Size = new System.Drawing.Size(899, 27);
            this.panel_Drag.TabIndex = 24;
            this.panel_Drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseDown);
            this.panel_Drag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseMove);
            this.panel_Drag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Drag_MouseUp);
            // 
            // panel_MiniSair
            // 
            this.panel_MiniSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel_MiniSair.Controls.Add(this.button_minimizar);
            this.panel_MiniSair.Controls.Add(this.button_sair);
            this.panel_MiniSair.Location = new System.Drawing.Point(720, 1);
            this.panel_MiniSair.Name = "panel_MiniSair";
            this.panel_MiniSair.Size = new System.Drawing.Size(179, 26);
            this.panel_MiniSair.TabIndex = 0;
            this.panel_MiniSair.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MiniSair_MouseDown);
            this.panel_MiniSair.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MiniSair_MouseMove);
            this.panel_MiniSair.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MiniSair_MouseUp);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label_ToolTipUsername
            // 
            this.label_ToolTipUsername.AutoSize = true;
            this.label_ToolTipUsername.BackColor = System.Drawing.Color.Transparent;
            this.label_ToolTipUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_ToolTipUsername.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_ToolTipUsername.Location = new System.Drawing.Point(123, 182);
            this.label_ToolTipUsername.Name = "label_ToolTipUsername";
            this.label_ToolTipUsername.Size = new System.Drawing.Size(16, 17);
            this.label_ToolTipUsername.TabIndex = 26;
            this.label_ToolTipUsername.Text = "?";
            this.label_ToolTipUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_ToolTipUsername, "Tem de ter entre 3-10 caracteres");
            // 
            // label_ToolTipPassword
            // 
            this.label_ToolTipPassword.AutoSize = true;
            this.label_ToolTipPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_ToolTipPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_ToolTipPassword.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_ToolTipPassword.Location = new System.Drawing.Point(120, 384);
            this.label_ToolTipPassword.Name = "label_ToolTipPassword";
            this.label_ToolTipPassword.Size = new System.Drawing.Size(16, 17);
            this.label_ToolTipPassword.TabIndex = 47;
            this.label_ToolTipPassword.Text = "?";
            this.label_ToolTipPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_ToolTipPassword, "Tem de ter entre 3-10 caracteres");
            // 
            // Form_Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.FormBG;
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Drag);
            this.Controls.Add(this.panel_layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.MinimumSize = new System.Drawing.Size(900, 404);
            this.Name = "Form_Opcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.toolTip.SetToolTip(this, "Têm de ter entre 3-10 caracteres");
            this.Load += new System.EventHandler(this.Form_Opcoes_Load);
            this.panel_layout.ResumeLayout(false);
            this.panel_layout.PerformLayout();
            this.panel_Drag.ResumeLayout(false);
            this.panel_MiniSair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_layout;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_minimizar;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Panel panel_Drag;
        private System.Windows.Forms.Label label_OPCOES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label_utilizador;
        private System.Windows.Forms.Label label_linha;
        private System.Windows.Forms.TextBox textBox_ConfirmarNovoUsername;
        private System.Windows.Forms.Label label_ConfirmarNovoUsername;
        private System.Windows.Forms.TextBox textBox_NovoUtilizador;
        private System.Windows.Forms.Label label_NovoUsername;
        private System.Windows.Forms.Label label_MudarPass;
        private System.Windows.Forms.Label label_MudarUsername;
        private System.Windows.Forms.TextBox textBox_ConfirmarNovaPassword;
        private System.Windows.Forms.TextBox textBox_NovaPassword;
        private System.Windows.Forms.Label label_ConfirmarMudarPassword;
        private System.Windows.Forms.Label label_MudarPassword;
        private System.Windows.Forms.Button button_AlterarPassword;
        private System.Windows.Forms.Button button_AlterarUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_MiniSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_lgout;
        private System.Windows.Forms.Label label_ToolTipUsername;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_ToolTipPassword;
    }
}