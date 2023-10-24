# Blackjack

## Overview
This game is designed using Blazor WebAssembly and follows the traditional rules of Blackjack. The responsive UI provides a clean and intuitive gaming experience, with a focus on aesthetics and functionality.

## Preview (click to enlarge)
| **Interface** | **Responsive Design** | **Instructions Overlay** |
|:-------------------------:|:-------------------------:|:-------------------------:|
| <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/blackjack/blob/main/wwwroot/images/screenshots/Screenshot0.png" width="280" height="140"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/blackjack/blob/main/wwwroot/images/screenshots/Screenshot1.png" width="280" height="140"/> | <a target="_blank" rel="noreferrer"> <img src="https://github.com/G-C-Code/blackjack/blob/main/wwwroot/images/screenshots/Screenshot2.png" width="280" height="140"/> |

## Features
1. **Statistics Display:** The top-left corner of the game interface displays your current win streak and overall win rate.
2. **Instructions:** For newcomers to the game, there's an instruction button in the top-right corner that, when clicked, overlays the game with a detailed set of instructions.
3. **Dealer and Player UI:** The game board visually represents both the player and the dealer's cards, showing the score beside each player's name. Special symbols differentiate the card suits, enhancing the gaming experience.
4. **Card Dealing:** Players can either 'hit' for more cards or 'stand'. Once the player decides to 'stand', the game progresses to determine the winner.
5. **Winner Determination:** The game follows standard Blackjack rules for determining winners. If the player scores 21 with the initial two cards, it's a Blackjack win for them.
6. **Game Restart:** After a round concludes, players have the option to start a new game with a single click.

## Code Features
- **Toggle Instructions:** This functionality shows/hides the game instructions overlay.
- **Unicode Card Symbols:** The game utilizes Unicode symbols to represent each card visually, catering to Spades, Hearts, Diamonds, and Clubs.
- **Game Logic:** The game calculates the score for the dealer and the player and decides the winner based on standard Blackjack rules.
- **Dynamic UI:** Based on the game's progression, the UI dynamically adjusts to show buttons and messages appropriate for the player's current choices.

## How to Setup and Run
### Prerequisites:
- Install .NET SDK (5.0+ recommended).
- Optional: Use an IDE like Visual Studio or Visual Studio Code.
- A modern web browser (e.g., Chrome, Firefox, Edge).

### Setup:
- Clone the repo: `git clone https://github.com/G-C-Code/blackjack`.
- Navigate to the project: `cd path/to/repository-folder`.
- Install required packages: `dotnet restore`.

### Run:
- Build with: `dotnet build`.
- Start the game: `dotnet run`.
- Open a browser and go to https://localhost:5001/.

Dive in, play wisely, and good luck.
