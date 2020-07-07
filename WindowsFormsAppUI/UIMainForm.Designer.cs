namespace WindowsFormsAppUI
{
    partial class UIMainForm 
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
            this.buttonCode1 = new System.Windows.Forms.Button();
            this.buttonCode2 = new System.Windows.Forms.Button();
            this.buttonCode3 = new System.Windows.Forms.Button();
            this.buttonCode4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCode1
            // 
            this.buttonCode1.Enabled = false;
            this.buttonCode1.Location = new System.Drawing.Point(43, 34);
            this.buttonCode1.Name = "buttonCode1";
            this.buttonCode1.Size = new System.Drawing.Size(102, 100);
            this.buttonCode1.TabIndex = 0;
            this.buttonCode1.UseVisualStyleBackColor = false;
            // 
            // buttonCode2
            // 
            this.buttonCode2.Enabled = false;
            this.buttonCode2.Location = new System.Drawing.Point(172, 34);
            this.buttonCode2.Name = "buttonCode2";
            this.buttonCode2.Size = new System.Drawing.Size(102, 100);
            this.buttonCode2.TabIndex = 0;
            this.buttonCode2.UseVisualStyleBackColor = false;
            // 
            // buttonCode3
            // 
            this.buttonCode3.Enabled = false;
            this.buttonCode3.Location = new System.Drawing.Point(299, 34);
            this.buttonCode3.Name = "buttonCode3";
            this.buttonCode3.Size = new System.Drawing.Size(102, 100);
            this.buttonCode3.TabIndex = 0;
            this.buttonCode3.UseVisualStyleBackColor = false;
            // 
            // buttonCode4
            // 
            this.buttonCode4.Enabled = false;
            this.buttonCode4.Location = new System.Drawing.Point(428, 34);
            this.buttonCode4.Name = "buttonCode4";
            this.buttonCode4.Size = new System.Drawing.Size(102, 100);
            this.buttonCode4.TabIndex = 0;
            this.buttonCode4.UseVisualStyleBackColor = false;
            // 
            // UIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(890, 1748);
            this.Controls.Add(this.buttonCode4);
            this.Controls.Add(this.buttonCode3);
            this.Controls.Add(this.buttonCode2);
            this.Controls.Add(this.buttonCode1);
            this.Name = "UIMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.UIMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCode1;
        private System.Windows.Forms.Button buttonCode2;
        private System.Windows.Forms.Button buttonCode3;
        private System.Windows.Forms.Button buttonCode4;
    }
}