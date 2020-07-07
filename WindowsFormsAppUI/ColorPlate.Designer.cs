namespace WindowsFormsAppUI
{
    partial class ColorPlate
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
            this.Purple = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Cyan = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Purple
            // 
            this.Purple.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Purple.Location = new System.Drawing.Point(35, 25);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(95, 89);
            this.Purple.TabIndex = 0;
            this.Purple.UseVisualStyleBackColor = true;
            this.Purple.Click += new System.EventHandler(this.Purple_Click);
            // 
            // Red
            // 
            this.Red.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Red.Location = new System.Drawing.Point(156, 25);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(95, 89);
            this.Red.TabIndex = 1;
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Green
            // 
            this.Green.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Green.Location = new System.Drawing.Point(274, 25);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(95, 89);
            this.Green.TabIndex = 2;
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Cyan
            // 
            this.Cyan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cyan.Location = new System.Drawing.Point(394, 25);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(95, 89);
            this.Cyan.TabIndex = 3;
            this.Cyan.UseVisualStyleBackColor = true;
            this.Cyan.Click += new System.EventHandler(this.Cyan_Click);
            // 
            // Blue
            // 
            this.Blue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Blue.Location = new System.Drawing.Point(35, 130);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(95, 89);
            this.Blue.TabIndex = 4;
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Yellow
            // 
            this.Yellow.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Yellow.Location = new System.Drawing.Point(156, 130);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(95, 89);
            this.Yellow.TabIndex = 5;
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Brown
            // 
            this.Brown.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Brown.Location = new System.Drawing.Point(274, 130);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(95, 89);
            this.Brown.TabIndex = 6;
            this.Brown.UseVisualStyleBackColor = true;
            this.Brown.Click += new System.EventHandler(this.Brown_Click);
            // 
            // White
            // 
            this.White.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.White.Location = new System.Drawing.Point(394, 130);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(95, 89);
            this.White.TabIndex = 7;
            this.White.UseVisualStyleBackColor = true;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // ColorPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 249);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Cyan);
            this.Controls.Add(this.Brown);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Purple);
            this.MaximizeBox = false;
            this.Name = "ColorPlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick A Color:";
            this.Load += new System.EventHandler(this.ColorPlate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Cyan;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button White;
    }
}