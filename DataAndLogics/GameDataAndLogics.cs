using System;
using System.Collections.Generic;
using System.Text;

namespace GameDataAndLogics
{
    public class GameData
    {
        static readonly int sr_NumberOfElementsToGuess = 4;
        static readonly string sr_CorrectGuessSign = "####";
        static readonly string sr_CodeMask = "####";
        static readonly string sr_Bull = "#";
        static readonly string sr_Cow = "F";
        readonly int r_AmountOfUserGusses = 0;
        readonly string r_ComputerCode;
        
        string[,] m_UserGuesses = null;
        int m_RangMin = 'A';
        int m_RangMax = 'H';
        int m_MinNumOfGuesses = 4;
        int m_MaxNumOfGuesses = 10;
        int m_CurrentGuess = 0;
        bool m_ReachedEndOfGuesses = false;
        bool m_Won = false;
        bool m_GameOver = false;

        public GameData(int i_AmountOfUserGusses)
        {
            if (checkConstructorValidity(i_AmountOfUserGusses))
            {
                r_AmountOfUserGusses = i_AmountOfUserGusses;
                m_UserGuesses = new string[2, r_AmountOfUserGusses];
                r_ComputerCode = createCharCode(sr_NumberOfElementsToGuess);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public string[,] UserGuesses
        {
            get
            {
                return m_UserGuesses;
            }
        }

        public string CodeMask
        {
            get
            {
                return sr_CodeMask;
            }
        }

        public int NumberOfElementsToGuess
        {
            get
            {
                return sr_NumberOfElementsToGuess;
            }
        }

        public bool GameOver
        {
            get
            {
                return m_GameOver;
            }
        }

        public bool ReachedEndOfGuesses
        {
            get
            {
                return m_ReachedEndOfGuesses;
            }
        }

        public bool Won
        {
            get
            {
                return m_Won;
            }
        }

        public string ComputerCode
        {
            get
            {
                return r_ComputerCode;
            }
        }

        public int CurrentGuess
        {
            get
            {
                return m_CurrentGuess;
            }
        }

        public int AmountOfUserGusses
        {
            get
            {
                return r_AmountOfUserGusses;
            }
        }

        public bool InsertGuess(string i_UserInput)
        {
            bool valid = checkIfInputIsValidPractically(i_UserInput);
            if (valid)
            {
                m_UserGuesses[0, m_CurrentGuess] = i_UserInput;
                m_UserGuesses[1, m_CurrentGuess] = guessReusltProduce(i_UserInput);
                if (TurnIsCorrect(m_CurrentGuess))
                {
                    m_Won = true;
                    m_GameOver = true;
                }
                if (m_CurrentGuess + 1 == r_AmountOfUserGusses)
                {
                    m_ReachedEndOfGuesses = true;
                    m_GameOver = true;
                }
                m_CurrentGuess++;
            }
            return valid;
        }

        public bool TurnIsCorrect(int i_CurrentGuess)
        {
            bool guessIsCorrect = false;
            if (m_UserGuesses[1, i_CurrentGuess].Equals(sr_CorrectGuessSign))
            {
                guessIsCorrect = true;
            }
            return guessIsCorrect;
        }

        private bool checkConstructorValidity(int i_AmountOfUserGusses)
        {
            bool valid = false;
            if ((i_AmountOfUserGusses >= m_MinNumOfGuesses) && (i_AmountOfUserGusses <= m_MaxNumOfGuesses))
            {
                valid = true;
            }
            return valid;
        }

        private string createCharCode(int i_CodeSize)
        {
            StringBuilder code = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < sr_NumberOfElementsToGuess; i++)
            {
                int asciValue = random.Next(m_RangMin, m_RangMax + 1);
                char sign = (char)asciValue;
                if (!code.ToString().Contains(sign.ToString()))
                {
                    code.Append(sign);
                }
                else
                {
                    i--;
                }
            }
            return code.ToString();
        }

        private string guessReusltProduce(string i_GuessToCheck)
        {
            StringBuilder Bulls = new StringBuilder();
            StringBuilder Cows = new StringBuilder();
            StringBuilder None = new StringBuilder();
            for (int i = 0; i < sr_NumberOfElementsToGuess; i++)
            {
                if (i_GuessToCheck[i] == this.r_ComputerCode[i])
                {
                    Bulls.Append(sr_Bull);
                }
                else if (this.r_ComputerCode.Contains(i_GuessToCheck[i].ToString()))
                {
                    Cows.Append(sr_Cow);
                }
                else
                {
                    None.Append(" ");
                }
            }
            return Bulls.Append(Cows.Append(None)).ToString();
        }

        private bool checkIfInputIsValidPractically(string i_UserInput)
        {
            bool valid = true;
            StringBuilder Checker = new StringBuilder();
            if(i_UserInput.Length != sr_NumberOfElementsToGuess)
            {
                valid = false;
            }
            for (int i = 0; i < i_UserInput.Length; i++)
            {
                if ((i_UserInput[i] > m_RangMax) || (i_UserInput[i] < m_RangMin))
                {
                    valid = false;
                }
                if (Checker.ToString().Contains(i_UserInput[i].ToString()))
                {
                    valid = false;
                }
                Checker.Append(i_UserInput[i]);
            }
            return valid;
        }
    }
}
