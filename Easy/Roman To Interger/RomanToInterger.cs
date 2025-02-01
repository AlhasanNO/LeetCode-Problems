public class Solution
{
    public int RomanToInt(string s)
    {
        int number = 0;

        for (int i = 0; i < s.Length; i++)
        {
            string currentCharacter = s[i].ToString();

            if (currentCharacter == "M")
                number += 1000;

            else if (currentCharacter == "D")
                number += 500;

            else if (currentCharacter == "L")
                number += 50;

            else if (currentCharacter == "V")
                number += 5;

            else if (s[i] == 'C')
            {
                if (NextChar(i, s) == "M")
                {
                    number += 900;
                    i++;
                }

                else if (NextChar(i, s) == "D")
                {
                    number += 400;
                    i++;
                }

                else
                    number += 100;
            }

            else if (currentCharacter == "X")
            {
                if (NextChar(i, s) == "L")
                {
                    number += 40;
                    i++;
                }

                else if (NextChar(i, s) == "C")
                {
                    number += 90;
                    i++;
                }

                else
                    number += 10;
            }

            else if (currentCharacter == "I")
            {
                if (NextChar(i, s) == "V")
                {
                    number += 4;
                    i++;
                }

                else if (NextChar(i, s) == "X")
                {
                    number += 9;
                    i++;
                }

                else
                    number += 1;
            }
        }

        return number;
    }

    string NextChar(int i, string s)
    {
        i++;

        if (i >= s.Length)
            return string.Empty;

        return s[i].ToString();
    }
}