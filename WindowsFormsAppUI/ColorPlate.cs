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

    
    public partial class ColorPlate : Form
    {
        int m_AmounOfButtonsPickedInTurn;
        Button m_CurrentButton = new Button();
        readonly List<Color> r_ColorsPickInTurn = new List<Color>();
        readonly List<Button> r_ButtonsPickInTurn = new List<Button>();
      
        Nullable<Color> m_LastColorPicked = null;
        static readonly ColorAlreadyPickedMessage sr_ColorAlreadyPickedMessage = new ColorAlreadyPickedMessage();
        bool m_Success = true;

        public ColorPlate()
        {
            InitializeComponent();
        }

        public Nullable<Color> LastColorPicked
        {
            get
            {
                return m_LastColorPicked;
            }
            set
            {
                m_LastColorPicked = value;
            }
        }

        public int AmounOfButtonsPickedInTurn
        {
            get
            {
                return m_AmounOfButtonsPickedInTurn;
            }
            set
            {
                m_AmounOfButtonsPickedInTurn = value;
            }
        }

        public bool Success
        {
            get
            {
                return m_Success;
            }
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void Red_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void Cyan_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        } 

        private void Brown_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void White_Click(object sender, EventArgs e)
        {
            OnColorButton_Click(sender);
        }

        private void OnColorButton_Click(object sender)
        {
            if (r_ColorsPickInTurn.Contains((sender as Button).BackColor) && (sender as Button).BackColor != m_CurrentButton.BackColor)
            {
                sr_ColorAlreadyPickedMessage.ShowDialog();
                m_Success = false;
            }
            else
            {
                updateColorParameters(sender);
            }
        }

        private void updateColorParameters(object sender)
        {
            if (!r_ButtonsPickInTurn.Contains(m_CurrentButton))
            {
                r_ButtonsPickInTurn.Add(m_CurrentButton);
                m_AmounOfButtonsPickedInTurn++;
            }
            else
            {
                r_ColorsPickInTurn.Remove((m_CurrentButton.BackColor));
            }
            m_Success = true;
            m_LastColorPicked = (sender as Button).BackColor;
            r_ColorsPickInTurn.Add((sender as Button).BackColor);
            this.Visible = false;
        }

        public void FreeButtons(object sender, EventArgs e)
        {
            r_ColorsPickInTurn.Clear();
            r_ButtonsPickInTurn.Clear();
            AmounOfButtonsPickedInTurn = 0;
        }


       
        private void ColorPlate_Load(object sender, EventArgs e)
        {
            foreach (Button button in this.Controls)
            {
               button.BackColor = Color.FromName(button.Name);
            }
        }

        public void AddToButtonList(object sender, EventArgs e)
        {
            m_CurrentButton = sender as Button;
        }
    }
}
