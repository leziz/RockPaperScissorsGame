# RockPaperScissors

An implementation of Rock, Paper, Scissors written in ASP.Net MVC Core using double dispatch pattern.

Application is developed in Visual Studio Code in C# targetting dotnet framework netcoreapp3.1

## The Game

Game is played by two players, one of which or both can be played by the computer.

The automated computer strategy is to select a move (rock, paper, scissors) at random.

## Architecture

The UI is presented by an MVC website. The Model in MVC is just a container for user input. 
The Controller functionality is unit tesed in GameUI.Tests.

The game logic is implemented in the class library GameEngine. GameEngine is unit tesed in GameEngine.Tests

### GameEngine

The player moves Rock, Paper and Scissors are implemented using visitor pattern.

MoveGenerator is a factory that creates the correct move type depending on user UI selection.

MoveGenerator can also create random moves if player is sellected to be the computer.

Game consits of two players, one of which or both can be the computer.

### GameEngine.Tests

Contains unit tests for GameEngine

### GameUI

This is the MVC user interface which uses the GameEngine library to run the Rock, Paper, Scissors game.

### GameUI.Tests

Contains unit tests for MVC's controlller
