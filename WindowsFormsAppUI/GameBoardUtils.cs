using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DataAndLogics;

namespace WindowsFormsAppUI
{
    public class GameBoardUtils
    {

       
        public static void DefineBackColor(Button i_ButtonToChange, string i_valueToChangeTo)
        {
            bool parsed = Char.TryParse(i_valueToChangeTo, out char valueToChangeToAsChar);
            if (parsed)
            {
                eSquareColor buttonNewColor = parseStringToColor(valueToChangeToAsChar);
                i_ButtonToChange.BackColor = Color.FromName(Enum.GetName(typeof(eSquareColor), buttonNewColor));
            }
            else
            {
                throw new Exception();
            }
        }

        private static eSquareColor parseStringToColor(Char i_StringToParse)
        {
            eSquareColor buttonNewColor = eSquareColor.Default;
            foreach (eSquareColor buttonColor in Enum.GetValues(typeof(eSquareColor)))
            {
                if ((char)buttonColor == i_StringToParse)
                {
                    buttonNewColor = buttonColor;
                }
            }
            return buttonNewColor;
        }
        
        public static string ParseButtonsToString(List<Button> i_ButtonsToParse)
        {
            StringBuilder stringToReturn = new StringBuilder();
            foreach (Button button in i_ButtonsToParse)
            {
                stringToReturn.Append(parseColorToChar(button.BackColor));
            }
            return stringToReturn.ToString();
        }


      
        private static Char parseColorToChar(Color i_colorToParse)
        {
            Char colorBullsAndCows = ' ';
            foreach (eSquareColor buttonColor in Enum.GetValues(typeof(eSquareColor)))
            {
                if (Enum.GetName(typeof(eSquareColor), buttonColor).Equals(i_colorToParse.Name))
                {
                    colorBullsAndCows = (char)buttonColor;
                }
            }
            return colorBullsAndCows;
        }

        public static void putButtonsInMatrix(Button [,] i_ButtonsMatrix, UIMainForm i_Form, string i_ButtonName)
        {
            int count = 1;
            for(int j = 0; j < i_Form.NumberOfChances; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    Button newButton = new Button();
                    newButton.Name = string.Format("{0}{1}", i_ButtonName, count.ToString());
                    i_ButtonsMatrix[j, i] = newButton;
                    count++;
                }
            }
        }

        public static void putButtonsInArray(Button[] i_ButtonsArray, string i_ButtonName)
        {
            int count = 1;
            for (int j = 0; j < i_ButtonsArray.Length; j++)
            {
                Button newButton = new Button();
                newButton.Name = string.Format("{0}{1}", i_ButtonName, count.ToString());
                i_ButtonsArray[j] = newButton;
                count++;
            }
        }
    }
}
