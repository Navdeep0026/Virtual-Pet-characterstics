# Virtual Pet Game

## Project Description
The Virtual Pet Game is a console-based application written in C#. In this game, users can create and interact with a virtual pet by feeding it, playing with it, letting it rest, or checking its status. The game is designed to help users understand basic object-oriented programming concepts by defining a pet class with various properties and methods.

## Features
- Choose a pet type (e.g., cat, dog, rabbit) and name your pet.
- Feed the pet to decrease hunger and increase health.
- Play with the pet to increase happiness and hunger.
- Let the pet rest to increase health and decrease happiness.
- Check the pet's status to see its current hunger, happiness, and health levels.
- Exit the game at any time.

## Setup Instructions

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Steps to Run the Program

1. **Clone the Repository**
   ```sh
   git clone https://github.com/your-username/virtual-pet-game.git
   cd virtual-pet-game
   2. dotnet build
   3. dotnet run
   4. Follow the On-Screen Instructions
You will be prompted to choose a pet type and name your pet. Then, you will enter the main interaction loop where you can choose to feed the pet, play with the pet, let the pet rest, check the pet's status, or exit the game.


Code Overview
Pet Class
Defines the properties and behaviors of a pet, including its type, name, hunger, happiness, and health levels. It includes methods for:

Feeding the pet (Feed)
Playing with the pet (Play)
Letting the pet rest (Rest)
Displaying the pet's status (ShowStatus)
Main Class (Program)
Contains the main method that runs the game. It:

Initializes the pet based on user input
Displays the main menu
Handles user input
Executes corresponding actions based on the user's choice

Zoom Link: https://stuconestogacon-my.sharepoint.com/:v:/g/personal/navdeepkaur3190_conestogac_on_ca/EbP_brZXsLlJseJ6KvoACsMBmsZAVMxWYM1JX4vrD3IUyA?e=BSxaUe&nav=eyJyZWZlcnJhbEluZm8iOnsicmVmZXJyYWxBcHAiOiJTdHJlYW1XZWJBcHAiLCJyZWZlcnJhbFZpZXciOiJTaGFyZURpYWxvZy1MaW5rIiwicmVmZXJyYWxBcHBQbGF0Zm9ybSI6IldlYiIsInJlZmVycmFsTW9kZSI6InZpZXcifX0%3D
