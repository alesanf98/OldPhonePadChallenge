# Old Phone Pad Coding Challenge

This project was made to simulate typing a message using the layout of old mobile phone keypads. Each numeric button is associated with its corresponding letters, and pressing the button multiple times will cycle through said letters. The program can also simulate a pause between key presses, backspaces and a "send message" button.


## Problem Description

Given a string representing keypad button presses on a mobile phone, translate that string into its corresponding letters and commands, using the following guidelines:

- **Repeating a digit** cycles through the digit's characters.
- The **space (`' '`)** character indicates a 1-second pause between button presses, used to separate letters associated with the same button.
- The **asterisk (`*`)** character indicates a backspace. Either deletes the digit being currently written or, in case there's none, the last character on the output string.
- The **hash (`#`)** character indicates the "send message" command, meaning the end of the translated output.

## How To Run

With .NET SDK installed and a console opened in the project's directory, run the program with `dotnet run`.

## Test Cases

Up to 10 test cases are included in `Program.cs` which help demostrate a variety of critical scenarios, including edge and complex input cases.

## Author

Alejandro Sánchez Fong