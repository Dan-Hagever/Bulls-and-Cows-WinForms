using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppUI
{

   
    public partial class StartGameForm : Form
    {
        public StartGameForm()
        {
            InitializeComponent();
        }

        private void ButtonDefineLinesNumber_Click(object sender, EventArgs e)
        {
            UIMainForm.UpdateNumberOfChances();
            this.m_ButtonDefineLinesNumber.Text = string.Format("Number of chances: {0}", m_MainForm.NumberOfChances.ToString());
        }

        UIMainForm m_MainForm = new UIMainForm();

        private void StartGameForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Visible = false;
            m_MainForm.ShowDialog();
            this.Close();
        }
    }
}
