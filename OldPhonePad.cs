using System;
using System.Reflection.Metadata.Ecma335;

namespace OldPhonePadChallenge
{
  public static class OldPhone
  {
    /// <summary>
    /// Dictionary to associate each different phone keypad button with
    /// its corresponding characters.
    /// </summary>
    private static Dictionary<char, string> keypad = new()
    {
      { '0', " " },
      { '1', "" },
      { '2', "ABC" },
      { '3', "DEF" },
      { '4', "GHI" },
      { '5', "JKL" },
      { '6', "MNO" },
      { '7', "PQRS" },
      { '8', "TUV" },
      { '9', "WXYZ" }
    };

    /// <summary>
    /// Converts a string keypad input to its corresponding letters, 
    /// simulating the button presses of old phone keypads. 
    /// </summary>
    /// <param name="input">The string representing the keypad input.</param>
    /// <returns>The translated message from keypad button input into text.</returns>
    public static string OldPhonePad(string input)
    {
      string output = "";
      char lastDigit = '\0';
      int digitCount = 0;

      if (input != null && input != "")
      {
        foreach (char c in input)
        {
          if (c == '#')
          {
            // Char '#' signals the end of the input string
            if (lastDigit != '\0')
            {
              output += DigitsToLetter(lastDigit, digitCount);
            }
            break;
          }
          else if (c == '*')
          {
            // Char '*' signals to erase the last written letter on the output string
            if (digitCount == 0 && output.Length > 0)
            {
              output = output.Substring(0, output.Length - 1);
            }
            digitCount = 0;
            lastDigit = '\0';
          }
          else if (c == ' ')
          {
            // Char ' ' signals a 1 second pause between keypad inputs.
            if (lastDigit != '\0')
            {
              output += DigitsToLetter(lastDigit, digitCount);
              digitCount = 0;
              lastDigit = '\0';
            }
          }
          else if (char.IsDigit(c))
          {
            if (lastDigit == '\0')
            {
              lastDigit = c;
            }
            if (c == lastDigit)
            {
              // In case the digit is being repeated.
              digitCount++;
            }
            else
            {
              // In case a different digit was pressed.
              output += DigitsToLetter(lastDigit, digitCount);
              digitCount = 1;
              lastDigit = c;
            }
          }
        }
      }
      return output;
    }

    /// <summary>
    /// Converts a digit and the number of times it was pressed in quick succession to
    /// the corresponding character on an old phone keypad layout.
    /// </summary>
    /// <param name="digit">The digit key pressed.</param>
    /// <param name="times">The number of times the digit was pressed.</param>
    /// <returns>The resulting character from the old phone keypad conversion.</returns>
    public static char DigitsToLetter(char digit, int times)
    {
      string letters = keypad[digit];

      if (letters.Length > 0)
      {
        return letters[(times - 1) % letters.Length];
      }
      else
      {
        return '\0';
      }
    }
  }
}