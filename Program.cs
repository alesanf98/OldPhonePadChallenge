using System;

namespace OldPhonePadChallenge
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(
        "Test Case 1: Single digit\n" +
        "Input: 3#\n" +
        "Expected Output: D\n" +
        "Output: " + OldPhone.OldPhonePad("3#") + "\n");

      Console.WriteLine(
        "Test Case 2: Repeated digit\n" +
        "Input: 33333#\n" +
        "Expected Output: E\n" +
        "Output: " + OldPhone.OldPhonePad("33333#") + "\n");

      Console.WriteLine(
        "Test Case 3: Full words\n" +
        "Input: 4433555 555666096667775553\n" +
        "Expected Output: HELLO WORLD\n" +
        "Output: " + OldPhone.OldPhonePad("4433555 555666096667775553 3 3**#") + "\n");

      Console.WriteLine(
        "Test Case 4: Delete button\n" +
        "Input: 27*#\n" +
        "Expected Output: A\n" +
        "Output: " + OldPhone.OldPhonePad("27*#") + "\n");

      Console.WriteLine(
        "Test Case 5: Input with invalid characters\n" +
        "Input: A2BC22DE222F/-+&#\n" +
        "Expected Output: C\n" +
        "Output: " + OldPhone.OldPhonePad("A2BC22DE222F/-+&#") + "\n");

      Console.WriteLine(
        "Test Case 6: Deleting with nothing to delete\n" +
        "Input: 23***#\n" +
        "Expected Output: \n" +
        "Output: " + OldPhone.OldPhonePad("23***#") + "\n");

      Console.WriteLine(
        "Test Case 7: Multiple repeated special characters ' ' and '*'\n" +
        "Input: 2   2 ** 2#\n" +
        "Expected Output: A\n" +
        "Output: " + OldPhone.OldPhonePad("2   2 ** 2#") + "\n");

      Console.WriteLine(
        "Test Case 8: '1' button input\n" +
        "Input: 11441111 11144411111#\n" +
        "Expected Output: HI\n" +
        "Output: " + OldPhone.OldPhonePad("11441111 11144411111#") + "\n");

      Console.WriteLine(
        "Test Case 9: Input string starting with '#'\n" +
        "Input: #123#\n" +
        "Expected Output: \n" +
        "Output: " + OldPhone.OldPhonePad("#123#") + "\n");

      Console.WriteLine(
        "Test Case 10: Empty input string\n" +
        "Input: \n" +
        "Expected Output: \n" +
        "Output: " + OldPhone.OldPhonePad("") + "\n");
    }
  }
}
