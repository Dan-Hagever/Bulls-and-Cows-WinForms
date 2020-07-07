using System;
using System.Windows.Forms;
namespace WindowsFormsAppUI
{
    partial class StartGameForm
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
            this.m_ButtonDefineLinesNumber = new System.Windows.Forms.Button();
            this.m_ButtonStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ButtonDefineLinesNumber
            // 
            this.m_ButtonDefineLinesNumber.Location = new System.Drawing.Point(46, 31);
            this.m_ButtonDefineLinesNumber.Name = "m_ButtonDefineLinesNumber";
            this.m_ButtonDefineLinesNumber.Size = new System.Drawing.Size(623, 62);
            this.m_ButtonDefineLinesNumber.TabIndex = 0;
            this.m_ButtonDefineLinesNumber.Text = "Number of chances: 4";
            this.m_ButtonDefineLinesNumber.UseVisualStyleBackColor = true;
            this.m_ButtonDefineLinesNumber.Click += new System.EventHandler(this.ButtonDefineLinesNumber_Click);
            // 
            // m_ButtonStartGame
            // 
            this.m_ButtonStartGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_ButtonStartGame.Location = new System.Drawing.Point(483, 176);
            this.m_ButtonStartGame.Name = "m_ButtonStartGame";
            this.m_ButtonStartGame.Size = new System.Drawing.Size(186, 62);
            this.m_ButtonStartGame.TabIndex = 1;
            this.m_ButtonStartGame.Text = "Start";
            this.m_ButtonStartGame.UseVisualStyleBackColor = true;
            this.m_ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 273);
            this.Controls.Add(this.m_ButtonStartGame);
            this.Controls.Add(this.m_ButtonDefineLinesNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.StartGameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button m_ButtonDefineLinesNumber = new Button();
        private Button m_ButtonStartGame;
    }
}

