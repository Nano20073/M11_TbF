namespace M11_TbF
{
    partial class Form_Ajuda_Telefone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajuda_Telefone));
            this.button_OK = new System.Windows.Forms.Button();
            this.label_O = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_acha = new System.Windows.Forms.Label();
            this.label_RESPOSTA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.Location = new System.Drawing.Point(67, 191);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(153, 40);
            this.button_OK.TabIndex = 23;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_O
            // 
            this.label_O.AutoSize = true;
            this.label_O.ForeColor = System.Drawing.Color.White;
            this.label_O.Location = new System.Drawing.Point(12, 24);
            this.label_O.Name = "label_O";
            this.label_O.Size = new System.Drawing.Size(15, 13);
            this.label_O.TabIndex = 24;
            this.label_O.Text = "O";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::M11_TbF.Properties.Resources.Dog;
            this.pictureBox1.Location = new System.Drawing.Point(32, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label_acha
            // 
            this.label_acha.AutoSize = true;
            this.label_acha.ForeColor = System.Drawing.Color.White;
            this.label_acha.Location = new System.Drawing.Point(123, 24);
            this.label_acha.Name = "label_acha";
            this.label_acha.Size = new System.Drawing.Size(152, 13);
            this.label_acha.TabIndex = 26;
            this.label_acha.Text = "acha que a resposta correta é:";
            // 
            // label_RESPOSTA
            // 
            this.label_RESPOSTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_RESPOSTA.ForeColor = System.Drawing.Color.White;
            this.label_RESPOSTA.Location = new System.Drawing.Point(0, 88);
            this.label_RESPOSTA.Name = "label_RESPOSTA";
            this.label_RESPOSTA.Size = new System.Drawing.Size(284, 74);
            this.label_RESPOSTA.TabIndex = 27;
            this.label_RESPOSTA.Text = "RESPOSTA";
            this.label_RESPOSTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Ajuda_Telefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_RESPOSTA);
            this.Controls.Add(this.label_acha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_O);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Ajuda_Telefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Ajuda_Telefone";
            this.Load += new System.EventHandler(this.Form_Ajuda_Telefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_O;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_acha;
        private System.Windows.Forms.Label label_RESPOSTA;
    }
}