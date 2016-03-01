namespace M11_TbF
{
    partial class Form6
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
            this.button_mudar_IMG1 = new System.Windows.Forms.Button();
            this.button_mudar_IMG2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_mudar_IMG1
            // 
            this.button_mudar_IMG1.Location = new System.Drawing.Point(148, 114);
            this.button_mudar_IMG1.Name = "button_mudar_IMG1";
            this.button_mudar_IMG1.Size = new System.Drawing.Size(75, 23);
            this.button_mudar_IMG1.TabIndex = 0;
            this.button_mudar_IMG1.Text = "Imagem 1";
            this.button_mudar_IMG1.UseVisualStyleBackColor = true;
            this.button_mudar_IMG1.Click += new System.EventHandler(this.button_mudar_IMG1_Click);
            // 
            // button_mudar_IMG2
            // 
            this.button_mudar_IMG2.Location = new System.Drawing.Point(295, 114);
            this.button_mudar_IMG2.Name = "button_mudar_IMG2";
            this.button_mudar_IMG2.Size = new System.Drawing.Size(75, 23);
            this.button_mudar_IMG2.TabIndex = 1;
            this.button_mudar_IMG2.Text = "Imagem 2";
            this.button_mudar_IMG2.UseVisualStyleBackColor = true;
            this.button_mudar_IMG2.Click += new System.EventHandler(this.button_mudar_IMG2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 301);
            this.Controls.Add(this.button_mudar_IMG2);
            this.Controls.Add(this.button_mudar_IMG1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_mudar_IMG1;
        private System.Windows.Forms.Button button_mudar_IMG2;
    }
}