using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameDataAndLogics;

namespace WindowsFormsAppUI
{

   
    public partial class UIMainForm : Form
    {
        public UIMainForm()
        {
            InitializeComponent();
        }

        static GameData m_GameData;
        private static int m_NumberOfChances = 4;
        readonly List<Button> r_CodeButtons = new List<Button>();

     
        ColorPlate s_ColorPlate = new ColorPlate();
        static Button[,] s_ButtonsGuessMatrix = new Button[m_NumberOfChances, 4];
        static Button[,] s_ButtonResultMatrix = new Button[m_NumberOfChances, 4];
        static Button [] s_ArrowsButtons = new Button[m_NumberOfChances];

        private void UIMainForm_Load(object sender, EventArgs e)
        {
            initializeGameBoardAnData();
            PaintTermCodeButtons();
            this.PerformAutoScale();
            runTurn(sender, e);
        }

        public int NumberOfChances
        {
            get
            {
                return m_NumberOfChances;
            }
        }

        public static void UpdateNumberOfChances()
        {
            if (m_NumberOfChances < 10)
            {
                m_NumberOfChances++;
            }
            else
            {
                m_NumberOfChances = 4;
            }
        }
        
        private void runTurn(object sender, EventArgs e)
        {
            if (!m_GameData.GameOver)
            {
                for (int i = 0; i < m_GameData.NumberOfElementsToGuess; i++)
                {
                    s_ButtonsGuessMatrix[m_GameData.CurrentGuess, i].Enabled = true;
                }
            }
            else
            {
                PaintTermCodeButtons();
            }
        }

        private void initializeGameBoardAnData()
        {
            m_GameData = new GameData(m_NumberOfChances);
            r_CodeButtons.Add(buttonCode1);
            r_CodeButtons.Add(buttonCode2);
            r_CodeButtons.Add(buttonCode3);
            r_CodeButtons.Add(buttonCode4);
            s_ButtonsGuessMatrix = new Button[m_NumberOfChances, m_GameData.NumberOfElementsToGuess];
            s_ButtonResultMatrix = new Button[m_NumberOfChances, m_GameData.NumberOfElementsToGuess];
            s_ArrowsButtons = new Button[m_NumberOfChances];
            GameBoardUtils.putButtonsInMatrix(s_ButtonsGuessMatrix, this, "GuessButton");
            GameBoardUtils.putButtonsInArray(s_ArrowsButtons, "ArrowButton");
            GameBoardUtils.putButtonsInMatrix(s_ButtonResultMatrix, this, "ResultButton");
            putGuessButtonsOnBoard();
            putArrowButtonsOnBoard();
            putResultButtonsOnBoard();
        }

        public void PaintTermCodeButtons()
        {
            if (m_GameData.GameOver)
            {
                paintButtons(m_GameData.ComputerCode, r_CodeButtons);
            }
            else
            {
                paintButtons(m_GameData.CodeMask, r_CodeButtons);
            }
        }

        private void paintButtons(string i_ButtonsColors, List<Button> i_Buttons)
        {
            for(int i = 0; i < i_ButtonsColors.Length; i++)
            {
                GameBoardUtils.DefineBackColor(i_Buttons[i], i_ButtonsColors[i].ToString());
            }
        }

        private void putGuessButtonsOnBoard()
        {
            defineButtonMatrixParameters(s_ButtonsGuessMatrix, firstInRowGuessButtonLocation, InRowGuessButtonLocation, defineGuessButtonParametersBesideLocation);
        }

        private void putResultButtonsOnBoard()
        {
            defineButtonMatrixParameters(s_ButtonResultMatrix, firstInRowResultButtonLocation, InRowResultButtonLocation, defineResultButtonParameters);
        }

        private void putArrowButtonsOnBoard()
        {
            int row = 0;
            Button buttonToAdjust = null;
            foreach(Button button in s_ArrowsButtons)
            {
                buttonToAdjust = s_ButtonsGuessMatrix[row, 3];
                defineArrowButtonParameters(button);
                button.Location = new System.Drawing.Point(buttonToAdjust.Right + 5, (buttonToAdjust.Top - buttonToAdjust.Bottom)/2 + buttonToAdjust.Bottom - (button.Height / 2));
                row++;
                this.Controls.Add(button);
            }
        }

        private void defineButtonMatrixParameters(Button [,] i_ButtonMatrix, Action<Button,Button, int> i_FirstInRowButtonLoc, Action<Button, Button, int> i_InRowButtonLoc, Action<Button> i_DefineButtonParams)
        {
            Button lastButton = null;
            Button firstInLastRow = null;
            int numOfTheButtonInTheRow = 1;
            int rowNumber = 0;
            foreach (Button button in i_ButtonMatrix)
            {
                if (numOfTheButtonInTheRow == 1)
                {
                    i_FirstInRowButtonLoc.Invoke(button, firstInLastRow, rowNumber);
                    firstInLastRow = button;
                }
                else
                {
                    i_InRowButtonLoc.Invoke(button, lastButton, numOfTheButtonInTheRow);
                }
                if (firstInLastRow == null)
                {
                    firstInLastRow = button;
                }
                lastButton = button;
                defineGuessButtonParametersBesideLocation(button);
                i_DefineButtonParams.Invoke(button);
                rowNumber = updateRowNum(numOfTheButtonInTheRow, rowNumber);
                numOfTheButtonInTheRow = updateButtonInRowNum(numOfTheButtonInTheRow);
                
            }
        }

        private void firstInRowResultButtonLocation(Button i_Button, Button i_FirstInLastRow, int i_RowNumber)
        {
            i_Button.Location = new System.Drawing.Point(s_ArrowsButtons[i_RowNumber].Right + 5, s_ButtonsGuessMatrix[i_RowNumber, 0].Top);
        }

        private void firstInRowGuessButtonLocation(Button i_Button, Button i_FirstInLastRow, int i_RowNum)
        {
            if(i_FirstInLastRow == null)
            {
                i_Button.Location = new System.Drawing.Point(this.buttonCode1.Left, this.buttonCode1.Bottom + 20);
            }
            else
            {
                i_Button.Location = new System.Drawing.Point(i_FirstInLastRow.Left, i_FirstInLastRow.Bottom + 12);
            }
        }

        private void InRowGuessButtonLocation(Button i_Button, Button i_LastButton, int i_NumInRow)
        {
            i_Button.Location = new System.Drawing.Point(i_LastButton.Right + 10, i_LastButton.Top);
        }

        private void InRowResultButtonLocation(Button i_Button, Button i_LastButton, int i_NumInRow)
        {
            if (i_NumInRow == 2)
            {
                i_Button.Location = new System.Drawing.Point(i_LastButton.Right + 2, i_LastButton.Top);
            }
            else if (i_NumInRow == 3)
            {
                i_Button.Location = new System.Drawing.Point(i_LastButton.Left, i_LastButton.Bottom + 2);
            }
            else if (i_NumInRow == 4)
            {
                i_Button.Location = new System.Drawing.Point(i_LastButton.Left - i_LastButton.Width - 2, i_LastButton.Top);
            }
        }

        private void defineGuessButtonParametersBesideLocation(Button i_ButtonToDefine)
        {
            int tabIndex = 100;
            i_ButtonToDefine.Size = this.buttonCode1.Size;
            i_ButtonToDefine.TabIndex = tabIndex++;
            i_ButtonToDefine.UseVisualStyleBackColor = false;
            i_ButtonToDefine.Visible = true;
            i_ButtonToDefine.Click += new System.EventHandler(s_ColorPlate.AddToButtonList);
            i_ButtonToDefine.Click += new System.EventHandler(this.ButtonGuess_Click);
            i_ButtonToDefine.Enabled = false;
            this.Controls.Add(i_ButtonToDefine);
        }

        private void defineArrowButtonParameters(Button i_ButtonToDefine)
        {
            int tabIndex = 400;
            i_ButtonToDefine.Size = new System.Drawing.Size(43, 20);
            i_ButtonToDefine.Text = "-->>";
            i_ButtonToDefine.TabIndex = tabIndex++;
            i_ButtonToDefine.UseVisualStyleBackColor = false;
            i_ButtonToDefine.Visible = true;
            i_ButtonToDefine.Click += new System.EventHandler(this.ButtonArrow_Click);
            i_ButtonToDefine.Click += new System.EventHandler(s_ColorPlate.FreeButtons);
            i_ButtonToDefine.Enabled = false;
        }

        private void defineResultButtonParameters(Button i_ButtonToDefine)
        {
            i_ButtonToDefine.Size = new System.Drawing.Size(s_ButtonsGuessMatrix[0, 0].Width / 2, s_ButtonsGuessMatrix[0, 0].Height / 2);
            i_ButtonToDefine.UseVisualStyleBackColor = false;
            i_ButtonToDefine.Visible = true;
            i_ButtonToDefine.Enabled = false;
            this.Controls.Add(i_ButtonToDefine);
        }

        private int updateButtonInRowNum(int io_NumOfTheButtonInTheRow)
        {
            if (io_NumOfTheButtonInTheRow == m_GameData.NumberOfElementsToGuess)
            {
                io_NumOfTheButtonInTheRow = 1;
            }
            else
            {
                io_NumOfTheButtonInTheRow++;
            }
            return io_NumOfTheButtonInTheRow;
        }

        private int updateRowNum(int i_NumOfTheButtonInTheRow, int io_CurrRowNum)
        {
            if (i_NumOfTheButtonInTheRow == m_GameData.NumberOfElementsToGuess)
            {
                io_CurrRowNum++;
            }
            return io_CurrRowNum;
        }

        private void ButtonGuess_Click(object sender, EventArgs e)
        {
            try
            {
                //ensure the color plate opens only once
                s_ColorPlate.ShowDialog();
                s_ColorPlate.Enabled = false;
            }
            catch(Exception ex)
            {
                DialogResult resultOfDialog = s_ColorPlate.DialogResult;
                if ((s_ColorPlate.LastColorPicked != null) && (resultOfDialog == DialogResult.OK) && s_ColorPlate.Success)
                {
                    (sender as Button).BackColor = (Color)s_ColorPlate.LastColorPicked;
                }
                if (s_ColorPlate.AmounOfButtonsPickedInTurn == m_GameData.NumberOfElementsToGuess)
                {
                    s_ArrowsButtons[m_GameData.CurrentGuess].Enabled = true;
                }
                s_ColorPlate.Enabled = true;
            }
        }

        private void ButtonArrow_Click(object sender, EventArgs e)
        {
            paintResultButtons();
            (sender as Button).Enabled = false;
            runTurn(this, e);
        }

        private void paintResultButtons()
        {
            List<Button> buttonListToParse = new List<Button>();
            List<Button> buttonListToPaint = new List<Button>();
            for (int i = 0; i < m_GameData.NumberOfElementsToGuess; i++)
            {
                s_ButtonsGuessMatrix[m_GameData.CurrentGuess, i].Enabled = false;
                buttonListToPaint.Add(s_ButtonResultMatrix[m_GameData.CurrentGuess, i]);
                buttonListToParse.Add(s_ButtonsGuessMatrix[m_GameData.CurrentGuess, i]);
            }
            m_GameData.InsertGuess(GameBoardUtils.ParseButtonsToString(buttonListToParse));
            paintButtons(m_GameData.UserGuesses[1, m_GameData.CurrentGuess - 1], buttonListToPaint);
            for (int i = 0; i < m_GameData.NumberOfElementsToGuess; i++)
            {
                buttonListToPaint[i].Enabled = false;
                s_ButtonResultMatrix[m_GameData.CurrentGuess - 1, i] = buttonListToPaint[i];
            }
        }
    }
}

