# Overview

{This project is a console-based Tic-Tac-Toe game written in C#.
My goal with this software was to strengthen my understanding of core C# concepts, including:

- Variables & expressions
- Loops and conditionals
- Functions
- Classes & objects
- Inheritance using abstract classes
- Structs
- File input/output
- Organizing a multi-file C# program

The game allows a human player to compete against a computer (random-move AI).
The game updates the board after every turn and also saves the board state to save.txt.

This project helped me practice building a complete program from scratch while learning good structure and C# syntax.}



[Software Demo Video](https://www.loom.com/share/779addd24100495b84b23aa916d78da9)

# Development Environment

{I developed this application using:

- Visual Studio Code
- .NET SDK 8 / C# 12
- .NET CLI (dotnet run, dotnet build)
- Operating System: Windows

 Language & Libraries

- Language: C#
- Libraries used:
  - System (console input/output)
  - System.IO (file writing/reading)
  - System.Collections.Generic (optional depending on implementation)}

{Object-Oriented Structure ✔ PlayerBase — abstract base class ✔ HumanPlayer inherits from PlayerBase ✔ ComputerPlayer inherits from PlayerBase ✔ Board class manages the grid ✔ Game class runs the whole game loop ✔ MoveRecord struct demonstrates struct usage ✔ SaveSystem handles file I/O .}

# Useful Websites

{Make a list of websites that you found helpful in this project}

- [Web Site Name](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Web Site Name](https://www.w3schools.com/cs/)

# Future Work

{Make a list of things that you need to fix, improve, and add in the future.}

- Item 1 Add smarter AI instead of random moves
- Item 2 Improve UI
- Item 3 Keep and add input validation to avoid invalid entries