namespace M11_TbF
{
    partial class Form_Time_Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Time_Out));
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.Location = new System.Drawing.Point(224, 250);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(153, 40);
            this.button_OK.TabIndex = 26;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Time_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M11_TbF.Properties.Resources.time_is_over;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Time_Out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Time_Out";
            this.Load += new System.EventHandler(this.Form_Time_Out_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_OK;
    }
}